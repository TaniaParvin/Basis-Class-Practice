namespace InterestCalculationApp
{
    partial class InterestCalculatorUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intCalculateButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.interestcalculatorLabel = new System.Windows.Forms.Label();
            this.showInterestLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (in Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest =";
            // 
            // intCalculateButton
            // 
            this.intCalculateButton.Location = new System.Drawing.Point(185, 189);
            this.intCalculateButton.Name = "intCalculateButton";
            this.intCalculateButton.Size = new System.Drawing.Size(133, 23);
            this.intCalculateButton.TabIndex = 4;
            this.intCalculateButton.Text = "Interest Calculator";
            this.intCalculateButton.UseVisualStyleBackColor = true;
            this.intCalculateButton.Click += new System.EventHandler(this.intCalculateButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(165, 94);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(153, 20);
            this.timeTextBox.TabIndex = 6;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(165, 139);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(153, 20);
            this.balanceTextBox.TabIndex = 7;
            // 
            // bankComboBox
            // 
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Items.AddRange(new object[] {
            "Brac Bank",
            "DBBL Bank",
            "HSBC Bank"});
            this.bankComboBox.Location = new System.Drawing.Point(165, 41);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(153, 21);
            this.bankComboBox.TabIndex = 8;
            // 
            // interestcalculatorLabel
            // 
            this.interestcalculatorLabel.AutoSize = true;
            this.interestcalculatorLabel.Location = new System.Drawing.Point(147, 258);
            this.interestcalculatorLabel.Name = "interestcalculatorLabel";
            this.interestcalculatorLabel.Size = new System.Drawing.Size(0, 13);
            this.interestcalculatorLabel.TabIndex = 9;
            // 
            // showInterestLabel
            // 
            this.showInterestLabel.AutoSize = true;
            this.showInterestLabel.Location = new System.Drawing.Point(162, 248);
            this.showInterestLabel.Name = "showInterestLabel";
            this.showInterestLabel.Size = new System.Drawing.Size(0, 13);
            this.showInterestLabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Balance =";
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.Location = new System.Drawing.Point(162, 295);
            this.totalBalanceLabel.Name = "totalBalanceLabel";
            this.totalBalanceLabel.Size = new System.Drawing.Size(0, 13);
            this.totalBalanceLabel.TabIndex = 12;
            // 
            // InterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 365);
            this.Controls.Add(this.totalBalanceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showInterestLabel);
            this.Controls.Add(this.interestcalculatorLabel);
            this.Controls.Add(this.bankComboBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.intCalculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculatorUI";
            this.Text = "Interest Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button intCalculateButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.ComboBox bankComboBox;
        private System.Windows.Forms.Label interestcalculatorLabel;
        private System.Windows.Forms.Label showInterestLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalBalanceLabel;
    }
}

