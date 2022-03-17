namespace WinFormsAppTest
{
    partial class ViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(27, 59);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FirstNameTextBox_KeyUp);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(241, 59);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LastNameTextBox_KeyUp);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(28, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(246, 35);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Location = new System.Drawing.Point(28, 145);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(39, 15);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.Text = "Result";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 409);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "ViewForm";
            this.Text = "Name IPConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label FirstNameLabel;
        private Label LastNameLabel;
        public TextBox FirstNameTextBox;
        public TextBox LastNameTextBox;
        public Label ResultBox;
    }
}