namespace linearConversion
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
            this.inchesButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.headLabel = new System.Windows.Forms.Label();
            this.feetButton = new System.Windows.Forms.Button();
            this.yardButton = new System.Windows.Forms.Button();
            this.mileButton = new System.Windows.Forms.Button();
            this.enterLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inchesButton
            // 
            this.inchesButton.BackColor = System.Drawing.Color.DarkGray;
            this.inchesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inchesButton.Location = new System.Drawing.Point(106, 88);
            this.inchesButton.Name = "inchesButton";
            this.inchesButton.Size = new System.Drawing.Size(382, 52);
            this.inchesButton.TabIndex = 0;
            this.inchesButton.Text = "Inches to Centimetres";
            this.inchesButton.UseVisualStyleBackColor = false;
            this.inchesButton.Click += new System.EventHandler(this.inchesButton_Click);
            // 
            // headLabel
            // 
            this.headLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headLabel.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.Location = new System.Drawing.Point(-6, -4);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(615, 72);
            this.headLabel.TabIndex = 1;
            this.headLabel.Text = "Imperial to Metric";
            this.headLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feetButton
            // 
            this.feetButton.BackColor = System.Drawing.Color.DarkGray;
            this.feetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.feetButton.Location = new System.Drawing.Point(106, 146);
            this.feetButton.Name = "feetButton";
            this.feetButton.Size = new System.Drawing.Size(382, 52);
            this.feetButton.TabIndex = 3;
            this.feetButton.Text = "Feet to Centimetres";
            this.feetButton.UseVisualStyleBackColor = false;
            this.feetButton.Click += new System.EventHandler(this.feetButton_Click);
            // 
            // yardButton
            // 
            this.yardButton.BackColor = System.Drawing.Color.DarkGray;
            this.yardButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yardButton.Location = new System.Drawing.Point(106, 204);
            this.yardButton.Name = "yardButton";
            this.yardButton.Size = new System.Drawing.Size(382, 52);
            this.yardButton.TabIndex = 4;
            this.yardButton.Text = "Inches to Yards to Metres";
            this.yardButton.UseVisualStyleBackColor = false;
            this.yardButton.Click += new System.EventHandler(this.yardButton_Click);
            // 
            // mileButton
            // 
            this.mileButton.BackColor = System.Drawing.Color.DarkGray;
            this.mileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mileButton.Location = new System.Drawing.Point(106, 262);
            this.mileButton.Name = "mileButton";
            this.mileButton.Size = new System.Drawing.Size(382, 52);
            this.mileButton.TabIndex = 5;
            this.mileButton.Text = "Miles to Kilometres";
            this.mileButton.UseVisualStyleBackColor = false;
            this.mileButton.Click += new System.EventHandler(this.mileButton_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enterLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(98, 313);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(260, 49);
            this.enterLabel.TabIndex = 6;
            this.enterLabel.Text = "enter value to be converted";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(106, 415);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(382, 54);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.DarkGray;
            this.convertButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertButton.Location = new System.Drawing.Point(106, 360);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(382, 52);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(364, 324);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(124, 22);
            this.inputBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(605, 489);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.mileButton);
            this.Controls.Add(this.yardButton);
            this.Controls.Add(this.feetButton);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.inchesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Lienear Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inchesButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Button feetButton;
        private System.Windows.Forms.Button yardButton;
        private System.Windows.Forms.Button mileButton;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox inputBox;
    }
}

