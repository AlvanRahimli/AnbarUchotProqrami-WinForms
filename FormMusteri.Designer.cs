namespace AnbarUchotu
{
    partial class FormMusteri
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
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.NumericSatisSayi = new System.Windows.Forms.NumericUpDown();
            this.TextBoxNo = new System.Windows.Forms.TextBox();
            this.TextBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.ComboRayon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateSonSatis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxElaqe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericBorc = new System.Windows.Forms.NumericUpDown();
            this.ComboSatislar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSatisEtrafli = new System.Windows.Forms.Button();
            this.CheckRedakte = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBorc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müştərinin adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(195, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satışların sayı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "No.";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSubmit.Location = new System.Drawing.Point(238, 597);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(154, 39);
            this.BtnSubmit.TabIndex = 9;
            this.BtnSubmit.Text = "+ Əlavə et";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // NumericSatisSayi
            // 
            this.NumericSatisSayi.Enabled = false;
            this.NumericSatisSayi.Location = new System.Drawing.Point(195, 300);
            this.NumericSatisSayi.Margin = new System.Windows.Forms.Padding(5);
            this.NumericSatisSayi.Name = "NumericSatisSayi";
            this.NumericSatisSayi.Size = new System.Drawing.Size(197, 39);
            this.NumericSatisSayi.TabIndex = 6;
            // 
            // TextBoxNo
            // 
            this.TextBoxNo.Location = new System.Drawing.Point(14, 39);
            this.TextBoxNo.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxNo.Name = "TextBoxNo";
            this.TextBoxNo.ReadOnly = true;
            this.TextBoxNo.Size = new System.Drawing.Size(71, 39);
            this.TextBoxNo.TabIndex = 7;
            // 
            // TextBoxMusteriAdi
            // 
            this.TextBoxMusteriAdi.Location = new System.Drawing.Point(95, 39);
            this.TextBoxMusteriAdi.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxMusteriAdi.Name = "TextBoxMusteriAdi";
            this.TextBoxMusteriAdi.Size = new System.Drawing.Size(297, 39);
            this.TextBoxMusteriAdi.TabIndex = 1;
            // 
            // ComboRayon
            // 
            this.ComboRayon.FormattingEnabled = true;
            this.ComboRayon.Items.AddRange(new object[] {
            "Ağdam",
            "Ağdaş",
            "Ağcabədi",
            "Ağstafa",
            "Ağsu",
            "Astara",
            "Babək",
            "Balakən",
            "Bərdə",
            "Beyləqan",
            "Biləsuvar",
            "Cəbrayıl",
            "Cəlilabad",
            "Culfa",
            "Daşkəsən",
            "Füzuli",
            "Gədəbəy",
            "Goranboy",
            "Göyçay",
            "Göygöl",
            "Hacıqabul",
            "Xaçmaz",
            "Xızı",
            "Xocalı",
            "Xocavənd",
            "İmişli",
            "İsmayıllı",
            "Kəlbəcər",
            "Kəngərli",
            "Kürdəmir",
            "Qəbələ",
            "Qax",
            "Qazax",
            "Qobustan",
            "Quba",
            "Qubadlı",
            "Qusar",
            "Laçın",
            "Lənkəran",
            "Lerik",
            "Masallı",
            "Neftçala",
            "Oğuz",
            "Ordubad",
            "Saatlı",
            "Sabirabad",
            "Sədərək",
            "Salyan",
            "Samux",
            "Şabran",
            "Şahbuz",
            "Şəki",
            "Şamaxı",
            "Şəmkir",
            "Şərur",
            "Şuşa",
            "Siyəzən",
            "Tərtər",
            "Tovuz",
            "Ucar",
            "Yardımlı",
            "Yevlax",
            "Zəngilan",
            "Zaqatala",
            "Zərdab"});
            this.ComboRayon.Location = new System.Drawing.Point(14, 121);
            this.ComboRayon.Name = "ComboRayon";
            this.ComboRayon.Size = new System.Drawing.Size(284, 39);
            this.ComboRayon.TabIndex = 2;
            this.ComboRayon.Text = "Rayon seçin";
            this.ComboRayon.SelectedIndexChanged += new System.EventHandler(this.ComboRayon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rayon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Son satış tarixi";
            // 
            // DateSonSatis
            // 
            this.DateSonSatis.Enabled = false;
            this.DateSonSatis.Location = new System.Drawing.Point(14, 391);
            this.DateSonSatis.Name = "DateSonSatis";
            this.DateSonSatis.Size = new System.Drawing.Size(378, 39);
            this.DateSonSatis.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Əlaqə";
            // 
            // TextBoxElaqe
            // 
            this.TextBoxElaqe.Location = new System.Drawing.Point(14, 209);
            this.TextBoxElaqe.Name = "TextBoxElaqe";
            this.TextBoxElaqe.Size = new System.Drawing.Size(284, 39);
            this.TextBoxElaqe.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Borc";
            // 
            // NumericBorc
            // 
            this.NumericBorc.DecimalPlaces = 2;
            this.NumericBorc.Location = new System.Drawing.Point(14, 300);
            this.NumericBorc.Name = "NumericBorc";
            this.NumericBorc.Size = new System.Drawing.Size(150, 39);
            this.NumericBorc.TabIndex = 5;
            // 
            // ComboSatislar
            // 
            this.ComboSatislar.Enabled = false;
            this.ComboSatislar.FormattingEnabled = true;
            this.ComboSatislar.Location = new System.Drawing.Point(14, 479);
            this.ComboSatislar.Name = "ComboSatislar";
            this.ComboSatislar.Size = new System.Drawing.Size(378, 39);
            this.ComboSatislar.TabIndex = 7;
            this.ComboSatislar.SelectedIndexChanged += new System.EventHandler(this.ComboSatislar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 451);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Satışlar";
            // 
            // BtnSatisEtrafli
            // 
            this.BtnSatisEtrafli.Enabled = false;
            this.BtnSatisEtrafli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSatisEtrafli.Location = new System.Drawing.Point(298, 524);
            this.BtnSatisEtrafli.Name = "BtnSatisEtrafli";
            this.BtnSatisEtrafli.Size = new System.Drawing.Size(94, 39);
            this.BtnSatisEtrafli.TabIndex = 8;
            this.BtnSatisEtrafli.Text = "Ətraflı";
            this.BtnSatisEtrafli.UseVisualStyleBackColor = true;
            this.BtnSatisEtrafli.Click += new System.EventHandler(this.BtnSatisEtrafli_Click);
            // 
            // CheckRedakte
            // 
            this.CheckRedakte.AutoSize = true;
            this.CheckRedakte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckRedakte.Location = new System.Drawing.Point(14, 604);
            this.CheckRedakte.Name = "CheckRedakte";
            this.CheckRedakte.Size = new System.Drawing.Size(100, 29);
            this.CheckRedakte.TabIndex = 10;
            this.CheckRedakte.Text = "Redaktə";
            this.CheckRedakte.UseVisualStyleBackColor = true;
            this.CheckRedakte.CheckedChanged += new System.EventHandler(this.CheckRedakte_CheckedChanged);
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 650);
            this.Controls.Add(this.CheckRedakte);
            this.Controls.Add(this.BtnSatisEtrafli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboSatislar);
            this.Controls.Add(this.NumericBorc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxElaqe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateSonSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboRayon);
            this.Controls.Add(this.TextBoxMusteriAdi);
            this.Controls.Add(this.TextBoxNo);
            this.Controls.Add(this.NumericSatisSayi);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri əlavə et";
            this.Load += new System.EventHandler(this.FormMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBorc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.NumericUpDown NumericSatisSayi;
        private System.Windows.Forms.TextBox TextBoxNo;
        private System.Windows.Forms.TextBox TextBoxMusteriAdi;
        private System.Windows.Forms.ComboBox ComboRayon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateSonSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxElaqe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericBorc;
        private System.Windows.Forms.ComboBox ComboSatislar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSatisEtrafli;
        private System.Windows.Forms.CheckBox CheckRedakte;
    }
}