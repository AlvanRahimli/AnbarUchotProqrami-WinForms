﻿namespace AnbarUchotu
{
    partial class FormMalEtrafli
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
            this.TextBoxMalinAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxQablasma = new System.Windows.Forms.TextBox();
            this.NumericMiqdar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DatePickerIstehsal = new System.Windows.Forms.DateTimePicker();
            this.DatePickerSon = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxYekun = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NumericQiymet = new System.Windows.Forms.NumericUpDown();
            this.BtnClean = new System.Windows.Forms.Button();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumericSatis = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.RadioAlis = new System.Windows.Forms.RadioButton();
            this.RadioSatis = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMiqdar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQiymet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malın adı";
            // 
            // TextBoxMalinAdi
            // 
            this.TextBoxMalinAdi.Location = new System.Drawing.Point(91, 37);
            this.TextBoxMalinAdi.Name = "TextBoxMalinAdi";
            this.TextBoxMalinAdi.Size = new System.Drawing.Size(305, 39);
            this.TextBoxMalinAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qablaşma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miqdarı";
            // 
            // TextBoxQablasma
            // 
            this.TextBoxQablasma.Location = new System.Drawing.Point(12, 129);
            this.TextBoxQablasma.Name = "TextBoxQablasma";
            this.TextBoxQablasma.Size = new System.Drawing.Size(170, 39);
            this.TextBoxQablasma.TabIndex = 2;
            // 
            // NumericMiqdar
            // 
            this.NumericMiqdar.Location = new System.Drawing.Point(210, 129);
            this.NumericMiqdar.Name = "NumericMiqdar";
            this.NumericMiqdar.Size = new System.Drawing.Size(186, 39);
            this.NumericMiqdar.TabIndex = 3;
            this.NumericMiqdar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericMiqdar.ValueChanged += new System.EventHandler(this.AlisaGoreYekun);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = " Alış qiyməti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "İstehsal tarixi";
            // 
            // DatePickerIstehsal
            // 
            this.DatePickerIstehsal.Location = new System.Drawing.Point(12, 325);
            this.DatePickerIstehsal.Name = "DatePickerIstehsal";
            this.DatePickerIstehsal.Size = new System.Drawing.Size(384, 39);
            this.DatePickerIstehsal.TabIndex = 6;
            // 
            // DatePickerSon
            // 
            this.DatePickerSon.Location = new System.Drawing.Point(12, 427);
            this.DatePickerSon.Name = "DatePickerSon";
            this.DatePickerSon.Size = new System.Drawing.Size(384, 39);
            this.DatePickerSon.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Son istifadə tarixi";
            // 
            // TextBoxYekun
            // 
            this.TextBoxYekun.Location = new System.Drawing.Point(12, 531);
            this.TextBoxYekun.Name = "TextBoxYekun";
            this.TextBoxYekun.ReadOnly = true;
            this.TextBoxYekun.Size = new System.Drawing.Size(157, 39);
            this.TextBoxYekun.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(116, 627);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(162, 55);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+ Əlavə et";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NumericQiymet
            // 
            this.NumericQiymet.DecimalPlaces = 2;
            this.NumericQiymet.Location = new System.Drawing.Point(12, 229);
            this.NumericQiymet.Name = "NumericQiymet";
            this.NumericQiymet.Size = new System.Drawing.Size(170, 39);
            this.NumericQiymet.TabIndex = 4;
            this.NumericQiymet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericQiymet.ValueChanged += new System.EventHandler(this.AlisaGoreYekun);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(333, 627);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(63, 55);
            this.BtnClean.TabIndex = 9;
            this.BtnClean.Text = "Sil";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(12, 37);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(73, 39);
            this.TextBoxId.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(210, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Satış qiyməti";
            // 
            // NumericSatis
            // 
            this.NumericSatis.DecimalPlaces = 2;
            this.NumericSatis.Location = new System.Drawing.Point(210, 229);
            this.NumericSatis.Name = "NumericSatis";
            this.NumericSatis.Size = new System.Drawing.Size(186, 39);
            this.NumericSatis.TabIndex = 5;
            this.NumericSatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericSatis.ValueChanged += new System.EventHandler(this.AlisaGoreYekun);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 496);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yekun";
            // 
            // RadioAlis
            // 
            this.RadioAlis.AutoSize = true;
            this.RadioAlis.Checked = true;
            this.RadioAlis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioAlis.Location = new System.Drawing.Point(192, 519);
            this.RadioAlis.Name = "RadioAlis";
            this.RadioAlis.Size = new System.Drawing.Size(195, 29);
            this.RadioAlis.TabIndex = 11;
            this.RadioAlis.TabStop = true;
            this.RadioAlis.Text = "Alış qiymətinə görə";
            this.RadioAlis.UseVisualStyleBackColor = true;
            this.RadioAlis.CheckedChanged += new System.EventHandler(this.RadioAlis_CheckedChanged);
            // 
            // RadioSatis
            // 
            this.RadioSatis.AutoSize = true;
            this.RadioSatis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioSatis.Location = new System.Drawing.Point(192, 554);
            this.RadioSatis.Name = "RadioSatis";
            this.RadioSatis.Size = new System.Drawing.Size(204, 29);
            this.RadioSatis.TabIndex = 11;
            this.RadioSatis.Text = "Satış qiymətinə görə";
            this.RadioSatis.UseVisualStyleBackColor = true;
            this.RadioSatis.CheckedChanged += new System.EventHandler(this.RadioSatis_CheckedChanged);
            // 
            // FormMalEtrafli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 697);
            this.Controls.Add(this.RadioSatis);
            this.Controls.Add(this.RadioAlis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NumericSatis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.NumericQiymet);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TextBoxYekun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatePickerSon);
            this.Controls.Add(this.DatePickerIstehsal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericMiqdar);
            this.Controls.Add(this.TextBoxQablasma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMalinAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMalEtrafli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mal əlavə et";
            this.Load += new System.EventHandler(this.FormMalEtrafli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericMiqdar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQiymet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMalinAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxQablasma;
        private System.Windows.Forms.NumericUpDown NumericMiqdar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatePickerIstehsal;
        private System.Windows.Forms.DateTimePicker DatePickerSon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxYekun;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NumericQiymet;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumericSatis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RadioAlis;
        private System.Windows.Forms.RadioButton RadioSatis;
    }
}