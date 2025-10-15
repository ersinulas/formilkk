namespace formilkk
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
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(205, 72);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(264, 26);
            this.txtkullanici.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(205, 168);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '?';
            this.txtsifre.Size = new System.Drawing.Size(264, 26);
            this.txtsifre.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(302, 229);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(167, 41);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Location = new System.Drawing.Point(29, 229);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(167, 41);
            this.btnvazgec.TabIndex = 5;
            this.btnvazgec.Text = "Kapat";
            this.btnvazgec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // lblhata
            // 
            this.lblhata.AutoSize = true;
            this.lblhata.Location = new System.Drawing.Point(25, 300);
            this.lblhata.Name = "lblhata";
            this.lblhata.Size = new System.Drawing.Size(0, 24);
            this.lblhata.TabIndex = 7;
            this.lblhata.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 332);
            this.Controls.Add(this.lblhata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhata;
    }
}

