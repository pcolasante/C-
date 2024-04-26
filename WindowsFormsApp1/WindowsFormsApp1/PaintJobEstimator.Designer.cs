namespace JobPaintEstimator
{
    partial class PaintJobEstimator
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
            this.sqrFtNeededLabel = new System.Windows.Forms.Label();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.sqrFtNeededTextBox = new System.Windows.Forms.TextBox();
            this.paintPriceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.gallonsRequiredText = new System.Windows.Forms.Label();
            this.hoursRequiredText = new System.Windows.Forms.Label();
            this.paintCostText = new System.Windows.Forms.Label();
            this.laborChargesText = new System.Windows.Forms.Label();
            this.totalCostText = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.gallonsNeededLabel = new System.Windows.Forms.Label();
            this.hoursNeededLabel = new System.Windows.Forms.Label();
            this.costPaintLabel = new System.Windows.Forms.Label();
            this.chargesLaborLabel = new System.Windows.Forms.Label();
            this.costTotalLabel = new System.Windows.Forms.Label();
            this.DescriptiveText = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqrFtNeededLabel
            // 
            this.sqrFtNeededLabel.AutoSize = true;
            this.sqrFtNeededLabel.Location = new System.Drawing.Point(25, 114);
            this.sqrFtNeededLabel.Name = "sqrFtNeededLabel";
            this.sqrFtNeededLabel.Size = new System.Drawing.Size(171, 13);
            this.sqrFtNeededLabel.TabIndex = 1;
            this.sqrFtNeededLabel.Text = "Sqr. ft. of wall space to be painted:";
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(25, 154);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(124, 13);
            this.paintPriceLabel.TabIndex = 2;
            this.paintPriceLabel.Text = "Price of Paint per Gallon:";
            // 
            // sqrFtNeededTextBox
            // 
            this.sqrFtNeededTextBox.Location = new System.Drawing.Point(96, 130);
            this.sqrFtNeededTextBox.Name = "sqrFtNeededTextBox";
            this.sqrFtNeededTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqrFtNeededTextBox.TabIndex = 0;
            // 
            // paintPriceTextBox
            // 
            this.paintPriceTextBox.Location = new System.Drawing.Point(96, 170);
            this.paintPriceTextBox.Name = "paintPriceTextBox";
            this.paintPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintPriceTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // gallonsRequiredText
            // 
            this.gallonsRequiredText.AutoSize = true;
            this.gallonsRequiredText.Location = new System.Drawing.Point(254, 114);
            this.gallonsRequiredText.Name = "gallonsRequiredText";
            this.gallonsRequiredText.Size = new System.Drawing.Size(130, 13);
            this.gallonsRequiredText.TabIndex = 6;
            this.gallonsRequiredText.Text = "Gallons of Paint Required:";
            // 
            // hoursRequiredText
            // 
            this.hoursRequiredText.AutoSize = true;
            this.hoursRequiredText.Location = new System.Drawing.Point(254, 154);
            this.hoursRequiredText.Name = "hoursRequiredText";
            this.hoursRequiredText.Size = new System.Drawing.Size(126, 13);
            this.hoursRequiredText.TabIndex = 7;
            this.hoursRequiredText.Text = "Hours of Labor Required:";
            // 
            // paintCostText
            // 
            this.paintCostText.AutoSize = true;
            this.paintCostText.Location = new System.Drawing.Point(254, 196);
            this.paintCostText.Name = "paintCostText";
            this.paintCostText.Size = new System.Drawing.Size(70, 13);
            this.paintCostText.TabIndex = 8;
            this.paintCostText.Text = "Cost of Paint:";
            // 
            // laborChargesText
            // 
            this.laborChargesText.AutoSize = true;
            this.laborChargesText.Location = new System.Drawing.Point(254, 233);
            this.laborChargesText.Name = "laborChargesText";
            this.laborChargesText.Size = new System.Drawing.Size(79, 13);
            this.laborChargesText.TabIndex = 9;
            this.laborChargesText.Text = "Labor Charges:";
            // 
            // totalCostText
            // 
            this.totalCostText.AutoSize = true;
            this.totalCostText.Location = new System.Drawing.Point(254, 271);
            this.totalCostText.Name = "totalCostText";
            this.totalCostText.Size = new System.Drawing.Size(58, 13);
            this.totalCostText.TabIndex = 10;
            this.totalCostText.Text = "Total Cost:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(74, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gallonsNeededLabel
            // 
            this.gallonsNeededLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gallonsNeededLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsNeededLabel.Location = new System.Drawing.Point(284, 130);
            this.gallonsNeededLabel.Name = "gallonsNeededLabel";
            this.gallonsNeededLabel.Size = new System.Drawing.Size(100, 20);
            this.gallonsNeededLabel.TabIndex = 17;
            // 
            // hoursNeededLabel
            // 
            this.hoursNeededLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hoursNeededLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursNeededLabel.Location = new System.Drawing.Point(284, 170);
            this.hoursNeededLabel.Name = "hoursNeededLabel";
            this.hoursNeededLabel.Size = new System.Drawing.Size(100, 20);
            this.hoursNeededLabel.TabIndex = 18;
            // 
            // costPaintLabel
            // 
            this.costPaintLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.costPaintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintLabel.Location = new System.Drawing.Point(284, 211);
            this.costPaintLabel.Name = "costPaintLabel";
            this.costPaintLabel.Size = new System.Drawing.Size(100, 20);
            this.costPaintLabel.TabIndex = 19;
            // 
            // chargesLaborLabel
            // 
            this.chargesLaborLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chargesLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chargesLaborLabel.Location = new System.Drawing.Point(284, 248);
            this.chargesLaborLabel.Name = "chargesLaborLabel";
            this.chargesLaborLabel.Size = new System.Drawing.Size(100, 20);
            this.chargesLaborLabel.TabIndex = 20;
            // 
            // costTotalLabel
            // 
            this.costTotalLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.costTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costTotalLabel.Location = new System.Drawing.Point(284, 287);
            this.costTotalLabel.Name = "costTotalLabel";
            this.costTotalLabel.Size = new System.Drawing.Size(100, 20);
            this.costTotalLabel.TabIndex = 21;
            // 
            // DescriptiveText
            // 
            this.DescriptiveText.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptiveText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptiveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptiveText.Location = new System.Drawing.Point(28, 27);
            this.DescriptiveText.Name = "DescriptiveText";
            this.DescriptiveText.Size = new System.Drawing.Size(356, 52);
            this.DescriptiveText.TabIndex = 22;
            this.DescriptiveText.Text = "For every 15 sqrft of wall space, 1 gallon of paint and 8 hours of labor are need" +
    "ed to finish the job. There is a $20.00 fee per hour of labor.";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Location = new System.Drawing.Point(175, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PaintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(411, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.DescriptiveText);
            this.Controls.Add(this.costTotalLabel);
            this.Controls.Add(this.chargesLaborLabel);
            this.Controls.Add(this.costPaintLabel);
            this.Controls.Add(this.hoursNeededLabel);
            this.Controls.Add(this.gallonsNeededLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalCostText);
            this.Controls.Add(this.laborChargesText);
            this.Controls.Add(this.paintCostText);
            this.Controls.Add(this.hoursRequiredText);
            this.Controls.Add(this.gallonsRequiredText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.paintPriceTextBox);
            this.Controls.Add(this.sqrFtNeededTextBox);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.sqrFtNeededLabel);
            this.Name = "PaintJobEstimator";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sqrFtNeededLabel;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.TextBox sqrFtNeededTextBox;
        private System.Windows.Forms.TextBox paintPriceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label gallonsRequiredText;
        private System.Windows.Forms.Label hoursRequiredText;
        private System.Windows.Forms.Label paintCostText;
        private System.Windows.Forms.Label laborChargesText;
        private System.Windows.Forms.Label totalCostText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label gallonsNeededLabel;
        private System.Windows.Forms.Label hoursNeededLabel;
        private System.Windows.Forms.Label costPaintLabel;
        private System.Windows.Forms.Label chargesLaborLabel;
        private System.Windows.Forms.Label costTotalLabel;
        private System.Windows.Forms.Label DescriptiveText;
        private System.Windows.Forms.Button exitButton;
    }
}

