namespace AssessedExerciseWeek6
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
            this.AddNodeTextBox = new System.Windows.Forms.TextBox();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.NodeLabel = new System.Windows.Forms.Label();
            this.FromListBox = new System.Windows.Forms.ListBox();
            this.ToListBox = new System.Windows.Forms.ListBox();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EdgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNodeTextBox
            // 
            this.AddNodeTextBox.Location = new System.Drawing.Point(36, 47);
            this.AddNodeTextBox.Name = "AddNodeTextBox";
            this.AddNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddNodeTextBox.TabIndex = 0;
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(49, 73);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(75, 23);
            this.AddNodeButton.TabIndex = 1;
            this.AddNodeButton.Text = "Add Node";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // NodeLabel
            // 
            this.NodeLabel.AutoSize = true;
            this.NodeLabel.Location = new System.Drawing.Point(33, 9);
            this.NodeLabel.Name = "NodeLabel";
            this.NodeLabel.Size = new System.Drawing.Size(116, 13);
            this.NodeLabel.TabIndex = 2;
            this.NodeLabel.Text = "Total number of nodes:";
            // 
            // FromListBox
            // 
            this.FromListBox.FormattingEnabled = true;
            this.FromListBox.Location = new System.Drawing.Point(29, 121);
            this.FromListBox.Name = "FromListBox";
            this.FromListBox.Size = new System.Drawing.Size(120, 95);
            this.FromListBox.TabIndex = 3;
            // 
            // ToListBox
            // 
            this.ToListBox.FormattingEnabled = true;
            this.ToListBox.Location = new System.Drawing.Point(29, 239);
            this.ToListBox.Name = "ToListBox";
            this.ToListBox.Size = new System.Drawing.Size(120, 95);
            this.ToListBox.TabIndex = 4;
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(166, 217);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEdgeButton.TabIndex = 5;
            this.AddEdgeButton.Text = "Add Edge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select two nodes to add edge";
            // 
            // EdgeLabel
            // 
            this.EdgeLabel.AutoSize = true;
            this.EdgeLabel.Location = new System.Drawing.Point(155, 190);
            this.EdgeLabel.Name = "EdgeLabel";
            this.EdgeLabel.Size = new System.Drawing.Size(95, 13);
            this.EdgeLabel.TabIndex = 7;
            this.EdgeLabel.Text = "Number of Edges: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 344);
            this.Controls.Add(this.EdgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.ToListBox);
            this.Controls.Add(this.FromListBox);
            this.Controls.Add(this.NodeLabel);
            this.Controls.Add(this.AddNodeButton);
            this.Controls.Add(this.AddNodeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNodeTextBox;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Label NodeLabel;
        private System.Windows.Forms.ListBox FromListBox;
        private System.Windows.Forms.ListBox ToListBox;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EdgeLabel;
    }
}

