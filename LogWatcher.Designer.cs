namespace logWatcher
{
    partial class LogWatcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.directoryOfLogTextBox = new System.Windows.Forms.TextBox();
            this.startCheckingButton = new System.Windows.Forms.Button();
            this.errorCountLabel = new System.Windows.Forms.Label();
            this.warningCountLabel = new System.Windows.Forms.Label();
            this.stopCheckingButton = new System.Windows.Forms.Button();
            this.errorCountIntLabel = new System.Windows.Forms.Label();
            this.warningCountIntLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.scanWaitTimeTextBox = new System.Windows.Forms.TextBox();
            this.errorTabControl = new System.Windows.Forms.TabControl();
            this.errorTabPage = new System.Windows.Forms.TabPage();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.warningTabPage = new System.Windows.Forms.TabPage();
            this.warningListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.watcherProgressBar = new System.Windows.Forms.ProgressBar();
            this.errorTabControl.SuspendLayout();
            this.errorTabPage.SuspendLayout();
            this.warningTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory of Log";
            // 
            // directoryOfLogTextBox
            // 
            this.directoryOfLogTextBox.Location = new System.Drawing.Point(16, 29);
            this.directoryOfLogTextBox.Name = "directoryOfLogTextBox";
            this.directoryOfLogTextBox.Size = new System.Drawing.Size(190, 20);
            this.directoryOfLogTextBox.TabIndex = 1;
            // 
            // startCheckingButton
            // 
            this.startCheckingButton.Location = new System.Drawing.Point(428, 43);
            this.startCheckingButton.Name = "startCheckingButton";
            this.startCheckingButton.Size = new System.Drawing.Size(129, 73);
            this.startCheckingButton.TabIndex = 4;
            this.startCheckingButton.Text = "Start Checking!";
            this.startCheckingButton.UseVisualStyleBackColor = true;
            this.startCheckingButton.Click += new System.EventHandler(this.startCheckingButton_Click);
            // 
            // errorCountLabel
            // 
            this.errorCountLabel.AutoSize = true;
            this.errorCountLabel.Location = new System.Drawing.Point(32, 74);
            this.errorCountLabel.Name = "errorCountLabel";
            this.errorCountLabel.Size = new System.Drawing.Size(63, 13);
            this.errorCountLabel.TabIndex = 5;
            this.errorCountLabel.Text = "Error Count:";
            // 
            // warningCountLabel
            // 
            this.warningCountLabel.AutoSize = true;
            this.warningCountLabel.Location = new System.Drawing.Point(14, 106);
            this.warningCountLabel.Name = "warningCountLabel";
            this.warningCountLabel.Size = new System.Drawing.Size(81, 13);
            this.warningCountLabel.TabIndex = 6;
            this.warningCountLabel.Text = "Warning Count:";
            // 
            // stopCheckingButton
            // 
            this.stopCheckingButton.Location = new System.Drawing.Point(651, 43);
            this.stopCheckingButton.Name = "stopCheckingButton";
            this.stopCheckingButton.Size = new System.Drawing.Size(125, 74);
            this.stopCheckingButton.TabIndex = 7;
            this.stopCheckingButton.Text = "Stop Checking!";
            this.stopCheckingButton.UseVisualStyleBackColor = true;
            this.stopCheckingButton.Click += new System.EventHandler(this.stopCheckingButton_Click);
            // 
            // errorCountIntLabel
            // 
            this.errorCountIntLabel.AutoSize = true;
            this.errorCountIntLabel.Location = new System.Drawing.Point(95, 74);
            this.errorCountIntLabel.Name = "errorCountIntLabel";
            this.errorCountIntLabel.Size = new System.Drawing.Size(0, 13);
            this.errorCountIntLabel.TabIndex = 9;
            // 
            // warningCountIntLabel
            // 
            this.warningCountIntLabel.AutoSize = true;
            this.warningCountIntLabel.Location = new System.Drawing.Point(98, 106);
            this.warningCountIntLabel.Name = "warningCountIntLabel";
            this.warningCountIntLabel.Size = new System.Drawing.Size(0, 13);
            this.warningCountIntLabel.TabIndex = 10;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(212, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Scan Every:";
            // 
            // scanWaitTimeTextBox
            // 
            this.scanWaitTimeTextBox.Location = new System.Drawing.Point(101, 132);
            this.scanWaitTimeTextBox.Name = "scanWaitTimeTextBox";
            this.scanWaitTimeTextBox.Size = new System.Drawing.Size(28, 20);
            this.scanWaitTimeTextBox.TabIndex = 12;
            this.scanWaitTimeTextBox.Text = "5";
            // 
            // errorTabControl
            // 
            this.errorTabControl.Controls.Add(this.errorTabPage);
            this.errorTabControl.Controls.Add(this.warningTabPage);
            this.errorTabControl.Location = new System.Drawing.Point(1, 164);
            this.errorTabControl.Name = "errorTabControl";
            this.errorTabControl.SelectedIndex = 0;
            this.errorTabControl.Size = new System.Drawing.Size(845, 496);
            this.errorTabControl.TabIndex = 13;
            // 
            // errorTabPage
            // 
            this.errorTabPage.Controls.Add(this.errorListBox);
            this.errorTabPage.Location = new System.Drawing.Point(4, 22);
            this.errorTabPage.Name = "errorTabPage";
            this.errorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorTabPage.Size = new System.Drawing.Size(837, 470);
            this.errorTabPage.TabIndex = 0;
            this.errorTabPage.Text = "Errors";
            this.errorTabPage.UseVisualStyleBackColor = true;
            // 
            // errorListBox
            // 
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.HorizontalScrollbar = true;
            this.errorListBox.Location = new System.Drawing.Point(1, 0);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(835, 472);
            this.errorListBox.TabIndex = 0;
            // 
            // warningTabPage
            // 
            this.warningTabPage.Controls.Add(this.warningListBox);
            this.warningTabPage.Location = new System.Drawing.Point(4, 22);
            this.warningTabPage.Name = "warningTabPage";
            this.warningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.warningTabPage.Size = new System.Drawing.Size(837, 470);
            this.warningTabPage.TabIndex = 1;
            this.warningTabPage.Text = "Warnings";
            this.warningTabPage.UseVisualStyleBackColor = true;
            // 
            // warningListBox
            // 
            this.warningListBox.FormattingEnabled = true;
            this.warningListBox.HorizontalScrollbar = true;
            this.warningListBox.Location = new System.Drawing.Point(1, 2);
            this.warningListBox.Name = "warningListBox";
            this.warningListBox.Size = new System.Drawing.Size(835, 472);
            this.warningListBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seconds";
            // 
            // watcherProgressBar
            // 
            this.watcherProgressBar.Location = new System.Drawing.Point(428, 144);
            this.watcherProgressBar.Name = "watcherProgressBar";
            this.watcherProgressBar.Size = new System.Drawing.Size(347, 29);
            this.watcherProgressBar.TabIndex = 15;
            // 
            // LogWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 659);
            this.Controls.Add(this.watcherProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorTabControl);
            this.Controls.Add(this.scanWaitTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warningCountIntLabel);
            this.Controls.Add(this.errorCountIntLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.stopCheckingButton);
            this.Controls.Add(this.warningCountLabel);
            this.Controls.Add(this.errorCountLabel);
            this.Controls.Add(this.startCheckingButton);
            this.Controls.Add(this.directoryOfLogTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LogWatcher";
            this.Text = "XF Loader Log Watcher";
            this.errorTabControl.ResumeLayout(false);
            this.errorTabPage.ResumeLayout(false);
            this.warningTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryOfLogTextBox;
        private System.Windows.Forms.Button startCheckingButton;
        private System.Windows.Forms.Label errorCountLabel;
        private System.Windows.Forms.Label warningCountLabel;
        private System.Windows.Forms.Button stopCheckingButton;
        private System.Windows.Forms.Label errorCountIntLabel;
        private System.Windows.Forms.Label warningCountIntLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scanWaitTimeTextBox;
        private System.Windows.Forms.TabControl errorTabControl;
        private System.Windows.Forms.TabPage errorTabPage;
        private System.Windows.Forms.ListBox errorListBox;
        private System.Windows.Forms.TabPage warningTabPage;
        private System.Windows.Forms.ListBox warningListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar watcherProgressBar;
    }
}