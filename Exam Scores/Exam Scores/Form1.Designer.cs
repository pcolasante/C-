namespace Exam_Scores
{
    partial class examScore
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
            this.section1ListBox = new System.Windows.Forms.ListBox();
            this.section2ListBox = new System.Windows.Forms.ListBox();
            this.section3ListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.section1Label = new System.Windows.Forms.Label();
            this.section2Label = new System.Windows.Forms.Label();
            this.section3Label = new System.Windows.Forms.Label();
            this.avgS1Label = new System.Windows.Forms.Label();
            this.avgS2Label = new System.Windows.Forms.Label();
            this.avgS3Label = new System.Windows.Forms.Label();
            this.resultAvgS1Label = new System.Windows.Forms.Label();
            this.resultAvgS2Label = new System.Windows.Forms.Label();
            this.resultAvgS3Label = new System.Windows.Forms.Label();
            this.highestAllSectionsLabel = new System.Windows.Forms.Label();
            this.lowestAllSectionsLabel = new System.Windows.Forms.Label();
            this.resultAvgAllSectionsLabel = new System.Windows.Forms.Label();
            this.avgAllSectionsLabel = new System.Windows.Forms.Label();
            this.resultHighestAllSectionsLabel = new System.Windows.Forms.Label();
            this.resultLowestAllSectionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // section1ListBox
            // 
            this.section1ListBox.AccessibleDescription = "";
            this.section1ListBox.FormattingEnabled = true;
            this.section1ListBox.Location = new System.Drawing.Point(12, 30);
            this.section1ListBox.Name = "section1ListBox";
            this.section1ListBox.Size = new System.Drawing.Size(120, 173);
            this.section1ListBox.TabIndex = 0;
            // 
            // section2ListBox
            // 
            this.section2ListBox.FormattingEnabled = true;
            this.section2ListBox.Location = new System.Drawing.Point(153, 31);
            this.section2ListBox.Name = "section2ListBox";
            this.section2ListBox.Size = new System.Drawing.Size(120, 173);
            this.section2ListBox.TabIndex = 1;
            // 
            // section3ListBox
            // 
            this.section3ListBox.FormattingEnabled = true;
            this.section3ListBox.Location = new System.Drawing.Point(291, 31);
            this.section3ListBox.Name = "section3ListBox";
            this.section3ListBox.Size = new System.Drawing.Size(120, 173);
            this.section3ListBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(165, 260);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(91, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // section1Label
            // 
            this.section1Label.AutoSize = true;
            this.section1Label.Location = new System.Drawing.Point(47, 14);
            this.section1Label.Name = "section1Label";
            this.section1Label.Size = new System.Drawing.Size(52, 13);
            this.section1Label.TabIndex = 5;
            this.section1Label.Text = "Section 1";
            // 
            // section2Label
            // 
            this.section2Label.AutoSize = true;
            this.section2Label.Location = new System.Drawing.Point(186, 15);
            this.section2Label.Name = "section2Label";
            this.section2Label.Size = new System.Drawing.Size(52, 13);
            this.section2Label.TabIndex = 6;
            this.section2Label.Text = "Section 2";
            // 
            // section3Label
            // 
            this.section3Label.AutoSize = true;
            this.section3Label.Location = new System.Drawing.Point(326, 15);
            this.section3Label.Name = "section3Label";
            this.section3Label.Size = new System.Drawing.Size(52, 13);
            this.section3Label.TabIndex = 7;
            this.section3Label.Text = "Section 3";
            // 
            // avgS1Label
            // 
            this.avgS1Label.AutoSize = true;
            this.avgS1Label.Location = new System.Drawing.Point(12, 216);
            this.avgS1Label.Name = "avgS1Label";
            this.avgS1Label.Size = new System.Drawing.Size(50, 13);
            this.avgS1Label.TabIndex = 8;
            this.avgS1Label.Text = "Average:";
            // 
            // avgS2Label
            // 
            this.avgS2Label.AutoSize = true;
            this.avgS2Label.Location = new System.Drawing.Point(150, 216);
            this.avgS2Label.Name = "avgS2Label";
            this.avgS2Label.Size = new System.Drawing.Size(50, 13);
            this.avgS2Label.TabIndex = 9;
            this.avgS2Label.Text = "Average:";
            // 
            // avgS3Label
            // 
            this.avgS3Label.AutoSize = true;
            this.avgS3Label.Location = new System.Drawing.Point(288, 216);
            this.avgS3Label.Name = "avgS3Label";
            this.avgS3Label.Size = new System.Drawing.Size(50, 13);
            this.avgS3Label.TabIndex = 10;
            this.avgS3Label.Text = "Average:";
            // 
            // resultAvgS1Label
            // 
            this.resultAvgS1Label.AutoSize = true;
            this.resultAvgS1Label.Location = new System.Drawing.Point(119, 216);
            this.resultAvgS1Label.Name = "resultAvgS1Label";
            this.resultAvgS1Label.Size = new System.Drawing.Size(13, 13);
            this.resultAvgS1Label.TabIndex = 11;
            this.resultAvgS1Label.Text = "0";
            // 
            // resultAvgS2Label
            // 
            this.resultAvgS2Label.AutoSize = true;
            this.resultAvgS2Label.Location = new System.Drawing.Point(260, 216);
            this.resultAvgS2Label.Name = "resultAvgS2Label";
            this.resultAvgS2Label.Size = new System.Drawing.Size(13, 13);
            this.resultAvgS2Label.TabIndex = 12;
            this.resultAvgS2Label.Text = "0";
            // 
            // resultAvgS3Label
            // 
            this.resultAvgS3Label.AutoSize = true;
            this.resultAvgS3Label.Location = new System.Drawing.Point(398, 216);
            this.resultAvgS3Label.Name = "resultAvgS3Label";
            this.resultAvgS3Label.Size = new System.Drawing.Size(13, 13);
            this.resultAvgS3Label.TabIndex = 13;
            this.resultAvgS3Label.Text = "0";
            // 
            // highestAllSectionsLabel
            // 
            this.highestAllSectionsLabel.AutoSize = true;
            this.highestAllSectionsLabel.Location = new System.Drawing.Point(20, 341);
            this.highestAllSectionsLabel.Name = "highestAllSectionsLabel";
            this.highestAllSectionsLabel.Size = new System.Drawing.Size(170, 13);
            this.highestAllSectionsLabel.TabIndex = 14;
            this.highestAllSectionsLabel.Text = "Highest Score among All Sections:";
            // 
            // lowestAllSectionsLabel
            // 
            this.lowestAllSectionsLabel.AutoSize = true;
            this.lowestAllSectionsLabel.Location = new System.Drawing.Point(20, 374);
            this.lowestAllSectionsLabel.Name = "lowestAllSectionsLabel";
            this.lowestAllSectionsLabel.Size = new System.Drawing.Size(168, 13);
            this.lowestAllSectionsLabel.TabIndex = 15;
            this.lowestAllSectionsLabel.Text = "Lowest Score among All Sections:";
            // 
            // resultAvgAllSectionsLabel
            // 
            this.resultAvgAllSectionsLabel.AutoSize = true;
            this.resultAvgAllSectionsLabel.Location = new System.Drawing.Point(288, 305);
            this.resultAvgAllSectionsLabel.Name = "resultAvgAllSectionsLabel";
            this.resultAvgAllSectionsLabel.Size = new System.Drawing.Size(13, 13);
            this.resultAvgAllSectionsLabel.TabIndex = 16;
            this.resultAvgAllSectionsLabel.Text = "0";
            // 
            // avgAllSectionsLabel
            // 
            this.avgAllSectionsLabel.AutoSize = true;
            this.avgAllSectionsLabel.Location = new System.Drawing.Point(20, 305);
            this.avgAllSectionsLabel.Name = "avgAllSectionsLabel";
            this.avgAllSectionsLabel.Size = new System.Drawing.Size(123, 13);
            this.avgAllSectionsLabel.TabIndex = 17;
            this.avgAllSectionsLabel.Text = "Average of All Sections: ";
            // 
            // resultHighestAllSectionsLabel
            // 
            this.resultHighestAllSectionsLabel.AutoSize = true;
            this.resultHighestAllSectionsLabel.Location = new System.Drawing.Point(288, 341);
            this.resultHighestAllSectionsLabel.Name = "resultHighestAllSectionsLabel";
            this.resultHighestAllSectionsLabel.Size = new System.Drawing.Size(13, 13);
            this.resultHighestAllSectionsLabel.TabIndex = 18;
            this.resultHighestAllSectionsLabel.Text = "0";
            // 
            // resultLowestAllSectionsLabel
            // 
            this.resultLowestAllSectionsLabel.AutoSize = true;
            this.resultLowestAllSectionsLabel.Location = new System.Drawing.Point(288, 374);
            this.resultLowestAllSectionsLabel.Name = "resultLowestAllSectionsLabel";
            this.resultLowestAllSectionsLabel.Size = new System.Drawing.Size(13, 13);
            this.resultLowestAllSectionsLabel.TabIndex = 19;
            this.resultLowestAllSectionsLabel.Text = "0";
            // 
            // examScore
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 419);
            this.Controls.Add(this.resultLowestAllSectionsLabel);
            this.Controls.Add(this.resultHighestAllSectionsLabel);
            this.Controls.Add(this.avgAllSectionsLabel);
            this.Controls.Add(this.resultAvgAllSectionsLabel);
            this.Controls.Add(this.lowestAllSectionsLabel);
            this.Controls.Add(this.highestAllSectionsLabel);
            this.Controls.Add(this.resultAvgS3Label);
            this.Controls.Add(this.resultAvgS2Label);
            this.Controls.Add(this.resultAvgS1Label);
            this.Controls.Add(this.avgS3Label);
            this.Controls.Add(this.avgS2Label);
            this.Controls.Add(this.avgS1Label);
            this.Controls.Add(this.section3Label);
            this.Controls.Add(this.section2Label);
            this.Controls.Add(this.section1Label);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.section3ListBox);
            this.Controls.Add(this.section2ListBox);
            this.Controls.Add(this.section1ListBox);
            this.Name = "examScore";
            this.Text = "Exam Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox section1ListBox;
        private System.Windows.Forms.ListBox section2ListBox;
        private System.Windows.Forms.ListBox section3ListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label section1Label;
        private System.Windows.Forms.Label section2Label;
        private System.Windows.Forms.Label section3Label;
        private System.Windows.Forms.Label avgS1Label;
        private System.Windows.Forms.Label avgS2Label;
        private System.Windows.Forms.Label avgS3Label;
        private System.Windows.Forms.Label resultAvgS1Label;
        private System.Windows.Forms.Label resultAvgS2Label;
        private System.Windows.Forms.Label resultAvgS3Label;
        private System.Windows.Forms.Label highestAllSectionsLabel;
        private System.Windows.Forms.Label lowestAllSectionsLabel;
        private System.Windows.Forms.Label resultAvgAllSectionsLabel;
        private System.Windows.Forms.Label avgAllSectionsLabel;
        private System.Windows.Forms.Label resultHighestAllSectionsLabel;
        private System.Windows.Forms.Label resultLowestAllSectionsLabel;
    }
}

