namespace NewCalculator
{
    partial class OutKeyword
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber1.Location = new System.Drawing.Point(178, 167);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(72, 25);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Sayı 1";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText1.Location = new System.Drawing.Point(254, 167);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(0, 25);
            this.lblText1.TabIndex = 0;
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber2.Location = new System.Drawing.Point(482, 167);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(72, 25);
            this.lblNumber2.TabIndex = 0;
            this.lblNumber2.Text = "Sayı 2";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText2.Location = new System.Drawing.Point(558, 167);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(0, 25);
            this.lblText2.TabIndex = 0;
            // 
            // btnDice
            // 
            this.btnDice.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice.Location = new System.Drawing.Point(259, 279);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(293, 68);
            this.btnDice.TabIndex = 1;
            this.btnDice.Text = "Zar At";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // OutKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblNumber1);
            this.Name = "OutKeyword";
            this.Text = "OutKeyword";
            this.Load += new System.EventHandler(this.OutKeyword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnDice;
    }
}