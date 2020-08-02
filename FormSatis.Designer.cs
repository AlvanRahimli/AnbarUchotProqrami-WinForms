namespace AnbarUchotu
{
    partial class FormSatis
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
            this.BtnYeniMusteri = new System.Windows.Forms.Button();
            this.ComboMusteri = new System.Windows.Forms.ComboBox();
            this.BtnYeniMal = new System.Windows.Forms.Button();
            this.ComboMal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblQiymet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSayi = new System.Windows.Forms.Label();
            this.LblQablasma = new System.Windows.Forms.Label();
            this.LblIstehsal = new System.Windows.Forms.Label();
            this.LblSonIstifade = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NumericSayi = new System.Windows.Forms.NumericUpDown();
            this.NumericYekun = new System.Windows.Forms.NumericUpDown();
            this.BtnSat = new System.Windows.Forms.Button();
            this.ListSecilmisMallar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSebetdenSil = new System.Windows.Forms.Button();
            this.BtnSebeteAt = new System.Windows.Forms.Button();
            this.BtnEtrafliMusteri = new System.Windows.Forms.Button();
            this.BtnMalYenile = new System.Windows.Forms.Button();
            this.BtnMusteriYenile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblYekun = new System.Windows.Forms.Label();
            this.LblSatilib = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblSatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYekun)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnYeniMusteri.Location = new System.Drawing.Point(363, 12);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(111, 39);
            this.BtnYeniMusteri.TabIndex = 1;
            this.BtnYeniMusteri.Text = "+ Yeni";
            this.BtnYeniMusteri.UseVisualStyleBackColor = true;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.BtnYeniMusteri_Click);
            // 
            // ComboMusteri
            // 
            this.ComboMusteri.FormattingEnabled = true;
            this.ComboMusteri.Location = new System.Drawing.Point(12, 12);
            this.ComboMusteri.Name = "ComboMusteri";
            this.ComboMusteri.Size = new System.Drawing.Size(345, 39);
            this.ComboMusteri.TabIndex = 2;
            this.ComboMusteri.Text = "Müştəri seçin";
            this.ComboMusteri.SelectedIndexChanged += new System.EventHandler(this.ComboMusteri_SelectedIndexChanged);
            // 
            // BtnYeniMal
            // 
            this.BtnYeniMal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnYeniMal.Location = new System.Drawing.Point(363, 122);
            this.BtnYeniMal.Name = "BtnYeniMal";
            this.BtnYeniMal.Size = new System.Drawing.Size(111, 39);
            this.BtnYeniMal.TabIndex = 1;
            this.BtnYeniMal.Text = "+ Yeni";
            this.BtnYeniMal.UseVisualStyleBackColor = true;
            this.BtnYeniMal.Click += new System.EventHandler(this.BtnYeniMal_Click);
            // 
            // ComboMal
            // 
            this.ComboMal.FormattingEnabled = true;
            this.ComboMal.Location = new System.Drawing.Point(12, 122);
            this.ComboMal.Name = "ComboMal";
            this.ComboMal.Size = new System.Drawing.Size(345, 39);
            this.ComboMal.TabIndex = 2;
            this.ComboMal.Text = "Mal seçin";
            this.ComboMal.SelectedIndexChanged += new System.EventHandler(this.ComboMal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alış qiyməti";
            // 
            // LblQiymet
            // 
            this.LblQiymet.AutoSize = true;
            this.LblQiymet.Location = new System.Drawing.Point(206, 164);
            this.LblQiymet.Name = "LblQiymet";
            this.LblQiymet.Size = new System.Drawing.Size(146, 32);
            this.LblQiymet.TabIndex = 3;
            this.LblQiymet.Text = "*seçilməyib*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anbarda sayı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "İstehsal tarixi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Son istifadə";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Qablaşma";
            // 
            // LblSayi
            // 
            this.LblSayi.AutoSize = true;
            this.LblSayi.Location = new System.Drawing.Point(206, 248);
            this.LblSayi.Name = "LblSayi";
            this.LblSayi.Size = new System.Drawing.Size(146, 32);
            this.LblSayi.TabIndex = 3;
            this.LblSayi.Text = "*seçilməyib*";
            // 
            // LblQablasma
            // 
            this.LblQablasma.AutoSize = true;
            this.LblQablasma.Location = new System.Drawing.Point(206, 293);
            this.LblQablasma.Name = "LblQablasma";
            this.LblQablasma.Size = new System.Drawing.Size(146, 32);
            this.LblQablasma.TabIndex = 3;
            this.LblQablasma.Text = "*seçilməyib*";
            // 
            // LblIstehsal
            // 
            this.LblIstehsal.AutoSize = true;
            this.LblIstehsal.Location = new System.Drawing.Point(206, 335);
            this.LblIstehsal.Name = "LblIstehsal";
            this.LblIstehsal.Size = new System.Drawing.Size(146, 32);
            this.LblIstehsal.TabIndex = 3;
            this.LblIstehsal.Text = "*seçilməyib*";
            // 
            // LblSonIstifade
            // 
            this.LblSonIstifade.AutoSize = true;
            this.LblSonIstifade.Location = new System.Drawing.Point(206, 377);
            this.LblSonIstifade.Name = "LblSonIstifade";
            this.LblSonIstifade.Size = new System.Drawing.Size(146, 32);
            this.LblSonIstifade.TabIndex = 3;
            this.LblSonIstifade.Text = "*seçilməyib*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Sayı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "Yekun";
            // 
            // NumericSayi
            // 
            this.NumericSayi.Enabled = false;
            this.NumericSayi.Location = new System.Drawing.Point(56, 484);
            this.NumericSayi.Name = "NumericSayi";
            this.NumericSayi.Size = new System.Drawing.Size(105, 39);
            this.NumericSayi.TabIndex = 5;
            this.NumericSayi.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // NumericYekun
            // 
            this.NumericYekun.DecimalPlaces = 2;
            this.NumericYekun.Enabled = false;
            this.NumericYekun.Location = new System.Drawing.Point(205, 484);
            this.NumericYekun.Name = "NumericYekun";
            this.NumericYekun.Size = new System.Drawing.Size(105, 39);
            this.NumericYekun.TabIndex = 6;
            // 
            // BtnSat
            // 
            this.BtnSat.BackColor = System.Drawing.Color.Aqua;
            this.BtnSat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSat.FlatAppearance.BorderSize = 3;
            this.BtnSat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSat.ForeColor = System.Drawing.Color.Black;
            this.BtnSat.Location = new System.Drawing.Point(754, 580);
            this.BtnSat.Name = "BtnSat";
            this.BtnSat.Size = new System.Drawing.Size(181, 57);
            this.BtnSat.TabIndex = 7;
            this.BtnSat.Text = "Satışı təsdiqlə";
            this.BtnSat.UseVisualStyleBackColor = false;
            this.BtnSat.Click += new System.EventHandler(this.BtnSat_Click);
            // 
            // ListSecilmisMallar
            // 
            this.ListSecilmisMallar.FormattingEnabled = true;
            this.ListSecilmisMallar.ItemHeight = 31;
            this.ListSecilmisMallar.Location = new System.Drawing.Point(502, 57);
            this.ListSecilmisMallar.Name = "ListSecilmisMallar";
            this.ListSecilmisMallar.Size = new System.Drawing.Size(433, 407);
            this.ListSecilmisMallar.TabIndex = 8;
            this.ListSecilmisMallar.SelectedIndexChanged += new System.EventHandler(this.ListSecilmisMallar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Səbət";
            // 
            // BtnSebetdenSil
            // 
            this.BtnSebetdenSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSebetdenSil.Location = new System.Drawing.Point(871, 12);
            this.BtnSebetdenSil.Name = "BtnSebetdenSil";
            this.BtnSebetdenSil.Size = new System.Drawing.Size(64, 39);
            this.BtnSebetdenSil.TabIndex = 9;
            this.BtnSebetdenSil.Text = "Sil";
            this.BtnSebetdenSil.UseVisualStyleBackColor = true;
            this.BtnSebetdenSil.Click += new System.EventHandler(this.BtnSebetdenSil_Click);
            // 
            // BtnSebeteAt
            // 
            this.BtnSebeteAt.Location = new System.Drawing.Point(75, 558);
            this.BtnSebeteAt.Name = "BtnSebeteAt";
            this.BtnSebeteAt.Size = new System.Drawing.Size(220, 55);
            this.BtnSebeteAt.TabIndex = 10;
            this.BtnSebeteAt.Text = "Səbətə əlavə et";
            this.BtnSebeteAt.UseVisualStyleBackColor = true;
            this.BtnSebeteAt.Click += new System.EventHandler(this.BtnSebeteAt_Click);
            // 
            // BtnEtrafliMusteri
            // 
            this.BtnEtrafliMusteri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEtrafliMusteri.Location = new System.Drawing.Point(239, 57);
            this.BtnEtrafliMusteri.Name = "BtnEtrafliMusteri";
            this.BtnEtrafliMusteri.Size = new System.Drawing.Size(118, 38);
            this.BtnEtrafliMusteri.TabIndex = 11;
            this.BtnEtrafliMusteri.Text = "Ətraflı >>";
            this.BtnEtrafliMusteri.UseVisualStyleBackColor = true;
            this.BtnEtrafliMusteri.Click += new System.EventHandler(this.BtnEtrafliMusteri_Click);
            // 
            // BtnMalYenile
            // 
            this.BtnMalYenile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMalYenile.Location = new System.Drawing.Point(363, 167);
            this.BtnMalYenile.Name = "BtnMalYenile";
            this.BtnMalYenile.Size = new System.Drawing.Size(111, 37);
            this.BtnMalYenile.TabIndex = 12;
            this.BtnMalYenile.Text = "Yenilə";
            this.BtnMalYenile.UseVisualStyleBackColor = true;
            this.BtnMalYenile.Click += new System.EventHandler(this.BtnMalYenile_Click);
            // 
            // BtnMusteriYenile
            // 
            this.BtnMusteriYenile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMusteriYenile.Location = new System.Drawing.Point(363, 57);
            this.BtnMusteriYenile.Name = "BtnMusteriYenile";
            this.BtnMusteriYenile.Size = new System.Drawing.Size(111, 37);
            this.BtnMusteriYenile.TabIndex = 12;
            this.BtnMusteriYenile.Text = "Yenilə";
            this.BtnMusteriYenile.UseVisualStyleBackColor = true;
            this.BtnMusteriYenile.Click += new System.EventHandler(this.BtnMusteriYenile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yekun:";
            // 
            // LblYekun
            // 
            this.LblYekun.AutoSize = true;
            this.LblYekun.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYekun.Location = new System.Drawing.Point(591, 481);
            this.LblYekun.Name = "LblYekun";
            this.LblYekun.Size = new System.Drawing.Size(81, 46);
            this.LblYekun.TabIndex = 14;
            this.LblYekun.Text = "0.00";
            // 
            // LblSatilib
            // 
            this.LblSatilib.AutoSize = true;
            this.LblSatilib.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSatilib.ForeColor = System.Drawing.Color.Red;
            this.LblSatilib.Location = new System.Drawing.Point(362, 547);
            this.LblSatilib.Name = "LblSatilib";
            this.LblSatilib.Size = new System.Drawing.Size(223, 78);
            this.LblSatilib.TabIndex = 14;
            this.LblSatilib.Text = "SATILIB";
            this.LblSatilib.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Satış qiyməti";
            // 
            // LblSatis
            // 
            this.LblSatis.AutoSize = true;
            this.LblSatis.Location = new System.Drawing.Point(206, 206);
            this.LblSatis.Name = "LblSatis";
            this.LblSatis.Size = new System.Drawing.Size(146, 32);
            this.LblSatis.TabIndex = 3;
            this.LblSatis.Text = "*seçilməyib*";
            // 
            // FormSatis
            // 
            this.ClientSize = new System.Drawing.Size(947, 649);
            this.Controls.Add(this.LblSatis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblSatilib);
            this.Controls.Add(this.LblYekun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMusteriYenile);
            this.Controls.Add(this.BtnMalYenile);
            this.Controls.Add(this.BtnEtrafliMusteri);
            this.Controls.Add(this.BtnSebeteAt);
            this.Controls.Add(this.BtnSebetdenSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListSecilmisMallar);
            this.Controls.Add(this.BtnSat);
            this.Controls.Add(this.NumericYekun);
            this.Controls.Add(this.NumericSayi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblSonIstifade);
            this.Controls.Add(this.LblIstehsal);
            this.Controls.Add(this.LblQablasma);
            this.Controls.Add(this.LblSayi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblQiymet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboMal);
            this.Controls.Add(this.BtnYeniMal);
            this.Controls.Add(this.ComboMusteri);
            this.Controls.Add(this.BtnYeniMusteri);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSatis";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYekun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboMusteri;
        private System.Windows.Forms.Button BtnYeniMusteri;
        private System.Windows.Forms.ComboBox ComboMal;
        private System.Windows.Forms.Button BtnYeniMal;
        private System.Windows.Forms.NumericUpDown NumericSayi;
        private System.Windows.Forms.Label LblQiymet;
        private System.Windows.Forms.Label LblQablasma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSayi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblSonIstifade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblIstehsal;
        private System.Windows.Forms.Button BtnSebetdenSil;
        private System.Windows.Forms.Button BtnSebeteAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NumericYekun;
        private System.Windows.Forms.Button BtnSat;
        private System.Windows.Forms.ListBox ListSecilmisMallar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEtrafliMusteri;
        private System.Windows.Forms.Button BtnMalYenile;
        private System.Windows.Forms.Button BtnMusteriYenile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblYekun;
        private System.Windows.Forms.Label LblSatilib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblSatis;
    }
}