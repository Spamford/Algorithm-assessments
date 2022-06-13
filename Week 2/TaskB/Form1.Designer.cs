namespace TaskB
{
    partial class Form1
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
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.NameEntryTextBox = new System.Windows.Forms.TextBox();
            this.EnqueueButton = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.DequeueButton = new System.Windows.Forms.Button();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.NumberInQueueLabel = new System.Windows.Forms.Label();
            this.ContentsLabel = new System.Windows.Forms.Label();
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.KButton = new System.Windows.Forms.Button();
            this.KListBox = new System.Windows.Forms.ListBox();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(12, 31);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(98, 13);
            this.EnterNameLabel.TabIndex = 0;
            this.EnterNameLabel.Text = "Please Enter Name";
            // 
            // NameEntryTextBox
            // 
            this.NameEntryTextBox.Location = new System.Drawing.Point(131, 28);
            this.NameEntryTextBox.Name = "NameEntryTextBox";
            this.NameEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameEntryTextBox.TabIndex = 1;
            // 
            // EnqueueButton
            // 
            this.EnqueueButton.Location = new System.Drawing.Point(147, 71);
            this.EnqueueButton.Name = "EnqueueButton";
            this.EnqueueButton.Size = new System.Drawing.Size(75, 23);
            this.EnqueueButton.TabIndex = 2;
            this.EnqueueButton.Text = "Enqueue";
            this.EnqueueButton.UseVisualStyleBackColor = true;
            this.EnqueueButton.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(128, 51);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.FeedbackLabel.TabIndex = 3;
            // 
            // DequeueButton
            // 
            this.DequeueButton.Location = new System.Drawing.Point(147, 100);
            this.DequeueButton.Name = "DequeueButton";
            this.DequeueButton.Size = new System.Drawing.Size(75, 23);
            this.DequeueButton.TabIndex = 5;
            this.DequeueButton.Text = "Dequeue";
            this.DequeueButton.UseVisualStyleBackColor = true;
            this.DequeueButton.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(27, 103);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(60, 20);
            this.CountTextBox.TabIndex = 7;
            // 
            // NumberInQueueLabel
            // 
            this.NumberInQueueLabel.AutoSize = true;
            this.NumberInQueueLabel.Location = new System.Drawing.Point(12, 81);
            this.NumberInQueueLabel.Name = "NumberInQueueLabel";
            this.NumberInQueueLabel.Size = new System.Drawing.Size(90, 13);
            this.NumberInQueueLabel.TabIndex = 10;
            this.NumberInQueueLabel.Text = "Number in Queue";
            // 
            // ContentsLabel
            // 
            this.ContentsLabel.AutoSize = true;
            this.ContentsLabel.Location = new System.Drawing.Point(41, 194);
            this.ContentsLabel.Name = "ContentsLabel";
            this.ContentsLabel.Size = new System.Drawing.Size(84, 13);
            this.ContentsLabel.TabIndex = 12;
            this.ContentsLabel.Text = "Queue Contents";
            // 
            // KTextBox
            // 
            this.KTextBox.Location = new System.Drawing.Point(318, 81);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(100, 20);
            this.KTextBox.TabIndex = 13;
            // 
            // KButton
            // 
            this.KButton.Location = new System.Drawing.Point(329, 107);
            this.KButton.Name = "KButton";
            this.KButton.Size = new System.Drawing.Size(75, 23);
            this.KButton.TabIndex = 14;
            this.KButton.Text = "Reverse";
            this.KButton.UseVisualStyleBackColor = true;
            this.KButton.Click += new System.EventHandler(this.KButton_Click);
            // 
            // KListBox
            // 
            this.KListBox.FormattingEnabled = true;
            this.KListBox.Location = new System.Drawing.Point(307, 154);
            this.KListBox.Name = "KListBox";
            this.KListBox.Size = new System.Drawing.Size(120, 95);
            this.KListBox.TabIndex = 15;
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(161, 154);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(120, 95);
            this.DisplayListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.KListBox);
            this.Controls.Add(this.KButton);
            this.Controls.Add(this.KTextBox);
            this.Controls.Add(this.ContentsLabel);
            this.Controls.Add(this.NumberInQueueLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.DequeueButton);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.EnqueueButton);
            this.Controls.Add(this.NameEntryTextBox);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.TextBox NameEntryTextBox;
        private System.Windows.Forms.Button EnqueueButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button DequeueButton;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label NumberInQueueLabel;
        private System.Windows.Forms.Label ContentsLabel;
        private System.Windows.Forms.TextBox KTextBox;
        private System.Windows.Forms.Button KButton;
        private System.Windows.Forms.ListBox KListBox;
        private System.Windows.Forms.ListBox DisplayListBox;
    }
}

