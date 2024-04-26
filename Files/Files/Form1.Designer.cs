namespace Files
{
    partial class RandomNumberFileReader
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
            this.intoLabel = new System.Windows.Forms.Label();
            this.totalNumbers = new System.Windows.Forms.Label();
            this.numbersReadLabel = new System.Windows.Forms.Label();
            this.readFileButton = new System.Windows.Forms.Button();
            this.numbersReadResultLabel = new System.Windows.Forms.Label();
            this.totalNumbersLabel = new System.Windows.Forms.Label();
            this.RandoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // intoLabel
            // 
            this.intoLabel.AutoSize = true;
            this.intoLabel.Location = new System.Drawing.Point(40, 29);
            this.intoLabel.Name = "intoLabel";
            this.intoLabel.Size = new System.Drawing.Size(189, 13);
            this.intoLabel.TabIndex = 1;
            this.intoLabel.Text = "List of Random Numbers from the File: ";
            // 
            // totalNumbers
            // 
            this.totalNumbers.AutoSize = true;
            this.totalNumbers.Location = new System.Drawing.Point(40, 246);
            this.totalNumbers.Name = "totalNumbers";
            this.totalNumbers.Size = new System.Drawing.Size(94, 13);
            this.totalNumbers.TabIndex = 2;
            this.totalNumbers.Text = "Total of Numbers: ";
            // 
            // numbersReadLabel
            // 
            this.numbersReadLabel.AutoSize = true;
            this.numbersReadLabel.Location = new System.Drawing.Point(40, 296);
            this.numbersReadLabel.Name = "numbersReadLabel";
            this.numbersReadLabel.Size = new System.Drawing.Size(229, 13);
            this.numbersReadLabel.TabIndex = 3;
            this.numbersReadLabel.Text = "Number of Random numbers read from the file: ";
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(162, 336);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 23);
            this.readFileButton.TabIndex = 4;
            this.readFileButton.Text = "READ FILE";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // numbersReadResultLabel
            // 
            this.numbersReadResultLabel.AutoSize = true;
            this.numbersReadResultLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numbersReadResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbersReadResultLabel.Location = new System.Drawing.Point(321, 296);
            this.numbersReadResultLabel.Name = "numbersReadResultLabel";
            this.numbersReadResultLabel.Size = new System.Drawing.Size(2, 15);
            this.numbersReadResultLabel.TabIndex = 6;
            // 
            // totalNumbersLabel
            // 
            this.totalNumbersLabel.AutoSize = true;
            this.totalNumbersLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.totalNumbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalNumbersLabel.Location = new System.Drawing.Point(321, 246);
            this.totalNumbersLabel.Name = "totalNumbersLabel";
            this.totalNumbersLabel.Size = new System.Drawing.Size(2, 15);
            this.totalNumbersLabel.TabIndex = 7;
            // 
            // RandoList
            // 
            this.RandoList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RandoList.FormattingEnabled = true;
            this.RandoList.Location = new System.Drawing.Point(43, 64);
            this.RandoList.Name = "RandoList";
            this.RandoList.Size = new System.Drawing.Size(299, 160);
            this.RandoList.TabIndex = 8;
            // 
            // RandomNumberFileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 374);
            this.Controls.Add(this.RandoList);
            this.Controls.Add(this.totalNumbersLabel);
            this.Controls.Add(this.numbersReadResultLabel);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.numbersReadLabel);
            this.Controls.Add(this.totalNumbers);
            this.Controls.Add(this.intoLabel);
            this.Name = "RandomNumberFileReader";
            this.Text = "Random Number File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intoLabel;
        private System.Windows.Forms.Label totalNumbers;
        private System.Windows.Forms.Label numbersReadLabel;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Label numbersReadResultLabel;
        private System.Windows.Forms.Label totalNumbersLabel;
        private System.Windows.Forms.ListBox RandoList;
    }
}

