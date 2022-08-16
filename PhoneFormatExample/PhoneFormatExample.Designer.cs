namespace NewCalculator
{
    partial class PhoneFormatExample
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
            this.txtInputPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnPhoneCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputPhone
            // 
            this.txtInputPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputPhone.Location = new System.Drawing.Point(227, 83);
            this.txtInputPhone.Name = "txtInputPhone";
            this.txtInputPhone.Size = new System.Drawing.Size(294, 32);
            this.txtInputPhone.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(110, 83);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 37);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone :";
            // 
            // btnPhoneCheck
            // 
            this.btnPhoneCheck.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneCheck.Location = new System.Drawing.Point(343, 164);
            this.btnPhoneCheck.Name = "btnPhoneCheck";
            this.btnPhoneCheck.Size = new System.Drawing.Size(178, 39);
            this.btnPhoneCheck.TabIndex = 2;
            this.btnPhoneCheck.Text = "Kontrol Et ";
            this.btnPhoneCheck.UseVisualStyleBackColor = true;
            this.btnPhoneCheck.Click += new System.EventHandler(this.btnPhoneCheck_Click);
            // 
            // PhoneFormatExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhoneCheck);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtInputPhone);
            this.Name = "PhoneFormatExample";
            this.Text = "PhoneFormatExample";
            this.Load += new System.EventHandler(this.PhoneFormatExample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnPhoneCheck;
    }
}