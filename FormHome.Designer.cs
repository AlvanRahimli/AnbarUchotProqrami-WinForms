namespace AnbarUchotu
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAnbar = new System.Windows.Forms.Button();
            this.BtnGelen_mal = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.BtnQaime = new System.Windows.Forms.Button();
            this.BtnMusteriSiyahisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnbar
            // 
            this.BtnAnbar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnbar.Location = new System.Drawing.Point(12, 242);
            this.BtnAnbar.Name = "BtnAnbar";
            this.BtnAnbar.Size = new System.Drawing.Size(340, 60);
            this.BtnAnbar.TabIndex = 1;
            this.BtnAnbar.Text = "Anbar";
            this.BtnAnbar.UseVisualStyleBackColor = true;
            this.BtnAnbar.Click += new System.EventHandler(this.BtnAnbar_Click);
            // 
            // BtnGelen_mal
            // 
            this.BtnGelen_mal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGelen_mal.Location = new System.Drawing.Point(12, 308);
            this.BtnGelen_mal.Name = "BtnGelen_mal";
            this.BtnGelen_mal.Size = new System.Drawing.Size(340, 60);
            this.BtnGelen_mal.TabIndex = 2;
            this.BtnGelen_mal.Text = "Gələn mal";
            this.BtnGelen_mal.UseVisualStyleBackColor = true;
            this.BtnGelen_mal.Click += new System.EventHandler(this.BtnGelen_mal_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSatis.Location = new System.Drawing.Point(12, 440);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(340, 60);
            this.BtnSatis.TabIndex = 4;
            this.BtnSatis.Text = "Satış";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // BtnQaime
            // 
            this.BtnQaime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQaime.Location = new System.Drawing.Point(12, 572);
            this.BtnQaime.Name = "BtnQaime";
            this.BtnQaime.Size = new System.Drawing.Size(340, 60);
            this.BtnQaime.TabIndex = 5;
            this.BtnQaime.Text = "Qaimə";
            this.BtnQaime.UseVisualStyleBackColor = true;
            // 
            // BtnMusteriSiyahisi
            // 
            this.BtnMusteriSiyahisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMusteriSiyahisi.Location = new System.Drawing.Point(12, 374);
            this.BtnMusteriSiyahisi.Name = "BtnMusteriSiyahisi";
            this.BtnMusteriSiyahisi.Size = new System.Drawing.Size(340, 60);
            this.BtnMusteriSiyahisi.TabIndex = 3;
            this.BtnMusteriSiyahisi.Text = "Müştəri siyahısı";
            this.BtnMusteriSiyahisi.UseVisualStyleBackColor = true;
            this.BtnMusteriSiyahisi.Click += new System.EventHandler(this.BtnMusteriSiyahisi_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 230);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölmə\r\nseçin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Satış siyaısı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(364, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMusteriSiyahisi);
            this.Controls.Add(this.BtnQaime);
            this.Controls.Add(this.BtnSatis);
            this.Controls.Add(this.BtnGelen_mal);
            this.Controls.Add(this.BtnAnbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana səhifə";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAnbar;
        private System.Windows.Forms.Button BtnGelen_mal;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button BtnQaime;
        private System.Windows.Forms.Button BtnMusteriSiyahisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

