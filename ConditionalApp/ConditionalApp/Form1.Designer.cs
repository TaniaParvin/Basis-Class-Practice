namespace ConditionalApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.planetComboBox = new System.Windows.Forms.ComboBox();
            this.planetNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet Name";
            // 
            // planetComboBox
            // 
            this.planetComboBox.FormattingEnabled = true;
            this.planetComboBox.Items.AddRange(new object[] {
            "Saturn",
            "Urenus",
            "Neptune",
            "Pluto"});
            this.planetComboBox.Location = new System.Drawing.Point(150, 40);
            this.planetComboBox.Name = "planetComboBox";
            this.planetComboBox.Size = new System.Drawing.Size(157, 21);
            this.planetComboBox.TabIndex = 1;
            
            // planetNumberButton
            // 
            this.planetNumberButton.Location = new System.Drawing.Point(162, 103);
            this.planetNumberButton.Name = "planetNumberButton";
            this.planetNumberButton.Size = new System.Drawing.Size(117, 23);
            this.planetNumberButton.TabIndex = 2;
            this.planetNumberButton.Text = "Show Planet Number";
            this.planetNumberButton.UseVisualStyleBackColor = true;
            this.planetNumberButton.Click += new System.EventHandler(this.planetNumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 169);
            this.Controls.Add(this.planetNumberButton);
            this.Controls.Add(this.planetComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox planetComboBox;
        private System.Windows.Forms.Button planetNumberButton;
    }
}

