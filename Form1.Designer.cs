namespace deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Silver;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Crimson;
            this.btn_temizle.Location = new System.Drawing.Point(292, 235);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(233, 39);
            this.btn_temizle.TabIndex = 1;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Silver;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giris.ForeColor = System.Drawing.Color.Crimson;
            this.btn_giris.Location = new System.Drawing.Point(47, 235);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(216, 39);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(292, 89);
            this.txt_kullaniciAdi.Multiline = true;
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(233, 30);
            this.txt_kullaniciAdi.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(292, 161);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(233, 31);
            this.txt_sifre.TabIndex = 4;
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_kullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullaniciadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(47, 89);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(180, 34);
            this.lbl_kullaniciadi.TabIndex = 5;
            this.lbl_kullaniciadi.Text = "✰Kullanıcı Adı:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sifre.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_sifre.Location = new System.Drawing.Point(47, 161);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(104, 34);
            this.lbl_sifre.TabIndex = 6;
            this.lbl_sifre.Text = "✰Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(626, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplantı Planlama Uygulamasına Hoşgeldiniz!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kullanıcı adınızı ve şifrenizi girerek devam edin.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_sifre);
            this.groupBox1.Controls.Add(this.lbl_kullaniciadi);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(696, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 322);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

