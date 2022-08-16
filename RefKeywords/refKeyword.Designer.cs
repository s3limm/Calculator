namespace NewCalculator
{
    partial class refKeyword
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(270, 106);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(272, 73);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(270, 278);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(272, 73);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "Referance";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // refKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnCopy);
            this.Name = "refKeyword";
            this.Text = "refKeyword";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRef;
    }
}