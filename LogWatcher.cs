using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace logWatcher
{
    public partial class LogWatcher : Form
    {
        public BackgroundWorker Worker;

        public delegate void SetTextCallBack (string text);

        public delegate void SetListCallBack(List<string> textToDisplay);
        private DateTime _lastShownError = DateTime.Now;
        private DateTime _lastShownWarn = DateTime.Now;
        public bool StopParsing { get; set; }
        public string DirectoryOfLog { get; set; }
        public LogWatcher()
        {
            InitializeComponent();
        }

        // ReSharper disable once UnusedMember.Local
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            GetFileName();
            if (DirectoryOfLog != null)
            {
                directoryOfLogTextBox.Text = DirectoryOfLog;              
            }
        }

        private void GetFileName()
        {
            var ofd = new OpenFileDialog();
            var dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DirectoryOfLog = ofd.FileName;
            }
        }

        private void stopCheckingButton_Click(object sender, EventArgs e)
        {
            StopParsing = true;
            if (Worker != null)
            {
                Worker.CancelAsync();
            }
            Worker = null;
        }

        private void startCheckingButton_Click(object sender, EventArgs e)
        {
            if (DirectoryOfLog == null) return;
            if (Worker != null) return;
            StopParsing = false;
            Worker = new BackgroundWorker {WorkerSupportsCancellation = true};
            Worker.DoWork += worker_DoWork;
            Worker.WorkerReportsProgress = true;
            Worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (File.Exists(DirectoryOfLog))
            {

                var parser = new Parser(DirectoryOfLog);

                do
                {
                    parser.SetErrors();
                    parser.SetWarnings();
                    SetErrorCountIntLabel(parser.GetErrorCount().ToString());
                    SetWarningCountIntLabel(parser.GetWarnCount().ToString());

                    var waitTime = TimeSpan.FromSeconds(double.Parse(scanWaitTimeTextBox.Text));
                    
                    var percentageComplete = 0;
                    Worker.ReportProgress(percentageComplete);
                        var errorList = parser.GetErrorMessages();
                        SetErrorListBox(errorList);
                        _lastShownError = DateTime.Now;
                     percentageComplete = 50;
                     Worker.ReportProgress(percentageComplete);
                        var warnList = parser.GetWarningMessages();
                        SetWarningListBox(warnList);
                        _lastShownWarn = DateTime.Now;
                    percentageComplete = 100;
                    Worker.ReportProgress(percentageComplete);
                    
                    System.Threading.Thread.Sleep(waitTime);

                } while (!StopParsing);
            }
            else
            {
                var cannotFindFileList = new List<string> {"Cannot Find XF Loader Logs"};
                SetErrorListBox(cannotFindFileList);
                SetWarningListBox(cannotFindFileList);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            watcherProgressBar.Value = e.ProgressPercentage;
        }
        private void SetErrorListBox(List<string> errorList)
        {
            if (errorListBox.InvokeRequired)
            {
                var d = new SetListCallBack(SetErrorListBox);
                Invoke(d, new object[] { errorList });
            }
            else
            {
                errorListBox.DataSource = null;
                //errorListBox.Items.Clear();               
                errorListBox.DataSource = errorList;
                errorListBox.SelectedIndex = errorList.Count() - 1 ;
                
            }
        }
        private void SetWarningListBox(List<string> warningList)
        {
            if (warningListBox.InvokeRequired)
            {
                var d = new SetListCallBack(SetWarningListBox);
                Invoke(d, new object[] { warningList });
            }
            else
            {
                warningListBox.DataSource = null;
                //warningListBox.Items.Clear();                
                warningListBox.DataSource = warningList;
                warningListBox.SelectedIndex = warningList.Count() - 1;
            }
        }
        private void SetErrorCountIntLabel(string errorCount)
        {
            if (errorCountIntLabel.InvokeRequired)
            {
                var d = new SetTextCallBack(SetErrorCountIntLabel);
                Invoke(d, new object[] { errorCount });
            }
            else
            {
                errorCountIntLabel.Text = errorCount;
            }
        }
        private void SetWarningCountIntLabel(string warnCount)
        {
            if (warningCountIntLabel.InvokeRequired)
            {
                var d = new SetTextCallBack(SetWarningCountIntLabel);
                Invoke(d, new object[] { warnCount });
            }
            else
            {
                warningCountIntLabel.Text = warnCount;

            }
        }
    }
}
