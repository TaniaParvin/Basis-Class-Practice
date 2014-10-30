namespace ExceptionApp
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
            this.totalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(178, 127);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 0;
            this.totalButton.Text = "Total Price";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Tickets";
            // 
            // noOfTicketsTextBox
            // 
            this.noOfTicketsTextBox.Location = new System.Drawing.Point(121, 54);
            this.noOfTicketsTextBox.Name = "noOfTicketsTextBox";
            this.noOfTicketsTextBox.Size = new System.Drawing.Size(158, 20);
            this.noOfTicketsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "One Ticket 100 Taka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.noOfTicketsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noOfTicketsTextBox;
        private System.Windows.Forms.Label label2;
    }
}

