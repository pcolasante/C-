namespace Making_Decisions
{
    partial class WorkshopSelector
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
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.registrationResultLabel = new System.Windows.Forms.Label();
            this.lodgingResultLabel = new System.Windows.Forms.Label();
            this.totalResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 16;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(36, 49);
            this.workshopListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(139, 116);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 16;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(257, 49);
            this.locationListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(139, 116);
            this.locationListBox.TabIndex = 1;
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(47, 29);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(65, 16);
            this.workshopLabel.TabIndex = 2;
            this.workshopLabel.Text = "Workshop";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(254, 29);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(55, 16);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calculateButton.Location = new System.Drawing.Point(151, 195);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 48);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(61, 271);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(124, 16);
            this.registrationLabel.TabIndex = 5;
            this.registrationLabel.Text = "Cost of Registration:";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Location = new System.Drawing.Point(61, 337);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(101, 16);
            this.lodgingLabel.TabIndex = 6;
            this.lodgingLabel.Text = "Cost of Lodging:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(61, 403);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 16);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total Cost:";
            // 
            // registrationResultLabel
            // 
            this.registrationResultLabel.AutoSize = true;
            this.registrationResultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registrationResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationResultLabel.Location = new System.Drawing.Point(268, 271);
            this.registrationResultLabel.Name = "registrationResultLabel";
            this.registrationResultLabel.Size = new System.Drawing.Size(26, 18);
            this.registrationResultLabel.TabIndex = 8;
            this.registrationResultLabel.Text = "$0";
            // 
            // lodgingResultLabel
            // 
            this.lodgingResultLabel.AutoSize = true;
            this.lodgingResultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lodgingResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingResultLabel.Location = new System.Drawing.Point(268, 337);
            this.lodgingResultLabel.Name = "lodgingResultLabel";
            this.lodgingResultLabel.Size = new System.Drawing.Size(26, 18);
            this.lodgingResultLabel.TabIndex = 9;
            this.lodgingResultLabel.Text = "$0";
            // 
            // totalResultLabel
            // 
            this.totalResultLabel.AutoSize = true;
            this.totalResultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalResultLabel.Location = new System.Drawing.Point(268, 403);
            this.totalResultLabel.Name = "totalResultLabel";
            this.totalResultLabel.Size = new System.Drawing.Size(26, 18);
            this.totalResultLabel.TabIndex = 10;
            this.totalResultLabel.Text = "$0";
            // 
            // WorkshopSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 441);
            this.Controls.Add(this.totalResultLabel);
            this.Controls.Add(this.lodgingResultLabel);
            this.Controls.Add(this.registrationResultLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workshopListBox);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkshopSelector";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label registrationResultLabel;
        private System.Windows.Forms.Label lodgingResultLabel;
        private System.Windows.Forms.Label totalResultLabel;
    }
}

