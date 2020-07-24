namespace AnbarUchotu
{
    partial class FormAnbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnbar));
            this.ListProducts = new System.Windows.Forms.ListView();
            this.Index = new System.Windows.Forms.ColumnHeader();
            this.MalinAdi = new System.Windows.Forms.ColumnHeader();
            this.Qablasma = new System.Windows.Forms.ColumnHeader();
            this.Miqdar = new System.Windows.Forms.ColumnHeader();
            this.BirEdedininQiymeti = new System.Windows.Forms.ColumnHeader();
            this.YekunQiymet = new System.Windows.Forms.ColumnHeader();
            this.IstehsalTarixi = new System.Windows.Forms.ColumnHeader();
            this.SonTarix = new System.Windows.Forms.ColumnHeader();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListProducts
            // 
            this.ListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.MalinAdi,
            this.Qablasma,
            this.Miqdar,
            this.BirEdedininQiymeti,
            this.YekunQiymet,
            this.IstehsalTarixi,
            this.SonTarix,
            this.Id});
            this.ListProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListProducts.HideSelection = false;
            this.ListProducts.Location = new System.Drawing.Point(12, 105);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(1075, 571);
            this.ListProducts.TabIndex = 0;
            this.ListProducts.UseCompatibleStateImageBehavior = false;
            this.ListProducts.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Name = "Index";
            this.Index.Text = "No";
            this.Index.Width = 50;
            // 
            // MalinAdi
            // 
            this.MalinAdi.Name = "MalinAdi";
            this.MalinAdi.Text = "Malın adı";
            this.MalinAdi.Width = 200;
            // 
            // Qablasma
            // 
            this.Qablasma.Name = "Qablasma";
            this.Qablasma.Text = "Qablaşma";
            this.Qablasma.Width = 130;
            // 
            // Miqdar
            // 
            this.Miqdar.Name = "Miqdar";
            this.Miqdar.Text = "Miqdarı";
            this.Miqdar.Width = 100;
            // 
            // BirEdedininQiymeti
            // 
            this.BirEdedininQiymeti.Name = "BirEdedininQiymeti";
            this.BirEdedininQiymeti.Text = "Qiymət";
            this.BirEdedininQiymeti.Width = 150;
            // 
            // YekunQiymet
            // 
            this.YekunQiymet.Name = "YekunQiymet";
            this.YekunQiymet.Text = "Yekun qiymət";
            this.YekunQiymet.Width = 150;
            // 
            // IstehsalTarixi
            // 
            this.IstehsalTarixi.Name = "IstehsalTarixi";
            this.IstehsalTarixi.Text = "İstehsal tarixi";
            this.IstehsalTarixi.Width = 200;
            // 
            // SonTarix
            // 
            this.SonTarix.Name = "SonTarix";
            this.SonTarix.Text = "Son tarix";
            this.SonTarix.Width = 200;
            // 
            // Id
            // 
            this.Id.Name = "Id";
            this.Id.Text = "Id";
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.BackgroundImage")));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRefresh.Location = new System.Drawing.Point(1027, 21);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(60, 60);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlus.BackgroundImage")));
            this.BtnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlus.Location = new System.Drawing.Point(98, 21);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(60, 60);
            this.BtnPlus.TabIndex = 1;
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdit.Location = new System.Drawing.Point(185, 21);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(60, 60);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Location = new System.Drawing.Point(273, 21);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(60, 60);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSell
            // 
            this.BtnSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSell.BackgroundImage")));
            this.BtnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSell.Location = new System.Drawing.Point(12, 21);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(60, 60);
            this.BtnSell.TabIndex = 1;
            this.BtnSell.UseVisualStyleBackColor = true;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // FormAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 688);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.ListProducts);
            this.Name = "FormAnbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anbar";
            this.Load += new System.EventHandler(this.FormAnbar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListProducts;
        private System.Windows.Forms.ColumnHeader MalinAdi;
        private System.Windows.Forms.ColumnHeader Qablasma;
        private System.Windows.Forms.ColumnHeader Miqdar;
        private System.Windows.Forms.ColumnHeader BirEdedininQiymeti;
        private System.Windows.Forms.ColumnHeader YekunQiymet;
        private System.Windows.Forms.ColumnHeader IstehsalTarixi;
        private System.Windows.Forms.ColumnHeader SonTarix;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.ColumnHeader Id;
    }
}