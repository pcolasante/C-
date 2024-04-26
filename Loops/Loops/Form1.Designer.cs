namespace Loops
{
    partial class randomNumberFileMaker
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
            this.randomInputLabel = new System.Windows.Forms.Label();
            this.randomInputTextBox = new System.Windows.Forms.TextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomInputLabel
            // 
            this.randomInputLabel.AutoSize = true;
            this.randomInputLabel.Location = new System.Drawing.Point(51, 38);
            this.randomInputLabel.Name = "randomInputLabel";
            this.randomInputLabel.Size = new System.Drawing.Size(269, 13);
            this.randomInputLabel.TabIndex = 0;
            this.randomInputLabel.Text = "Enter the desired amount of random numbers in the file: ";
            // 
            // randomInputTextBox
            // 
            this.randomInputTextBox.Location = new System.Drawing.Point(134, 69);
            this.randomInputTextBox.Name = "randomInputTextBox";
            this.randomInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.randomInputTextBox.TabIndex = 1;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(144, 124);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveFileButton.TabIndex = 2;
            this.saveFileButton.Text = "SAVE FILE";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // randomNumberFileMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 180);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.randomInputTextBox);
            this.Controls.Add(this.randomInputLabel);
            this.Name = "randomNumberFileMaker";
            this.Text = "Random Number File Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomInputLabel;
        private System.Windows.Forms.TextBox randomInputTextBox;
        private System.Windows.Forms.Button saveFileButton;
    }
}

