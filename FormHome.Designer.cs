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
            this.BtnQaliq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnQaime = new System.Windows.Forms.Button();
            this.BtnMusteriSiyahisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnbar
            // 
            this.BtnAnbar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnbar.Location = new System.Drawing.Point(155, 242);
            this.BtnAnbar.Name = "BtnAnbar";
            this.BtnAnbar.Size = new System.Drawing.Size(132, 117);
            this.BtnAnbar.TabIndex = 0;
            this.BtnAnbar.Text = "Anbar";
            this.BtnAnbar.UseVisualStyleBackColor = true;
            this.BtnAnbar.Click += new System.EventHandler(this.BtnAnbar_Click);
            // 
            // BtnGelen_mal
            // 
            this.BtnGelen_mal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGelen_mal.Location = new System.Drawing.Point(356, 242);
            this.BtnGelen_mal.Name = "BtnGelen_mal";
            this.BtnGelen_mal.Size = new System.Drawing.Size(132, 117);
            this.BtnGelen_mal.TabIndex = 0;
            this.BtnGelen_mal.Text = "Gələn mal";
            this.BtnGelen_mal.UseVisualStyleBackColor = true;
            // 
            // BtnSatis
            // 
            this.BtnSatis.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSatis.Location = new System.Drawing.Point(551, 242);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(132, 117);
            this.BtnSatis.TabIndex = 0;
            this.BtnSatis.Text = "Satış";
            this.BtnSatis.UseVisualStyleBackColor = true;
            // 
            // BtnQaliq
            // 
            this.BtnQaliq.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQaliq.Location = new System.Drawing.Point(752, 242);
            this.BtnQaliq.Name = "BtnQaliq";
            this.BtnQaliq.Size = new System.Drawing.Size(132, 117);
            this.BtnQaliq.TabIndex = 0;
            this.BtnQaliq.Text = "Qalıq";
            this.BtnQaliq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xoş gəlmisiniz";
            // 
            // BtnQaime
            // 
            this.BtnQaime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQaime.Location = new System.Drawing.Point(356, 416);
            this.BtnQaime.Name = "BtnQaime";
            this.BtnQaime.Size = new System.Drawing.Size(132, 117);
            this.BtnQaime.TabIndex = 0;
            this.BtnQaime.Text = "Qaimə";
            this.BtnQaime.UseVisualStyleBackColor = true;
            // 
            // BtnMusteriSiyahisi
            // 
            this.BtnMusteriSiyahisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMusteriSiyahisi.Location = new System.Drawing.Point(551, 416);
            this.BtnMusteriSiyahisi.Name = "BtnMusteriSiyahisi";
            this.BtnMusteriSiyahisi.Size = new System.Drawing.Size(132, 117);
            this.BtnMusteriSiyahisi.TabIndex = 0;
            this.BtnMusteriSiyahisi.Text = "Müştəri\r\nsiyahısı";
            this.BtnMusteriSiyahisi.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 618);
            this.Controls.Add(this.BtnMusteriSiyahisi);
            this.Controls.Add(this.BtnQaime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQaliq);
            this.Controls.Add(this.BtnSatis);
            this.Controls.Add(this.BtnGelen_mal);
            this.Controls.Add(this.BtnAnbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.Text = "Ana səhifə";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnbar;
        private System.Windows.Forms.Button BtnGelen_mal;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button BtnQaliq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnQaime;
        private System.Windows.Forms.Button BtnMusteriSiyahisi;
    }
}

