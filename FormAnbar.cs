using AnbarUchotu.Data;
using AnbarUchotu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace AnbarUchotu
{
    public partial class FormAnbar : Form
    {
        public List<Mal> Mallar { get; set; }
        public FormAnbar()
        {
            InitializeComponent();
        }

        private void FormAnbar_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            FormSatis formSatis;
            if (ListProducts.SelectedItems.Count == 0)
            {
                formSatis = new FormSatis();
            }
            else
            {
                var id = GetSelectedItemId();
                formSatis = new FormSatis(new int[] { id });
            }
            formSatis.Show();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            var formAdd = new FormMalEtrafli();
            formAdd.Show();
        }

        public void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            ListProducts.Items.Clear();

            LoadProducts();
        }

        public void LoadProducts()
        {
            using var context = new AppDbContext();
            var ps = context.Products.ToList();
            Mallar = ps;
            if (ps.Count > 0)
            {
                int no = 1;
                foreach (var item in ps)
                {
                    string[] cols =
                    {
                        item.MalAdi,
                        item.Qablasma.ToString(),
                        item.AnbardakiMiqdar.ToString(),
                        ((decimal)item.AlisQiymeti / 100).ToString(),
                        ((decimal)item.SatisQiymeti / 100).ToString(),
                        ((decimal)item.YekunQiymet / 100).ToString(),
                        item.Istehsal.ToShortDateString(),
                        item.SonIstifade.ToShortDateString(),
                        item.Id.ToString()
                    };

                    var newItem = new ListViewItem(no.ToString());
                    if ((item.SonIstifade - DateTime.Today).Days < 150)
                    {
                        newItem.BackColor = Color.Red;
                        newItem.ForeColor = Color.White;
                    }

                    if (item.AnbardakiMiqdar == 0)
                    {
                        newItem.BackColor = Color.LightBlue;
                    }

                    ListProducts.Items.Add(newItem).SubItems.AddRange(cols);
                    no++;
                }
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedItemId();
            if (id == 0) return;

            using var context = new AppDbContext();
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

            var formEdit = new FormMalEtrafli(product);
            formEdit.Show();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedItemId();
            if (id == 0) return;

            using var context = new AppDbContext();
            var produkt = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

            context.Products.Remove(produkt);
            var result = await context.SaveChangesAsync();

            if (result > 0)
            {
                MessageBox.Show("Mal siyahıdan silindi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silinərkən səhv baş verdi.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListProducts.Items.Clear();
            LoadProducts();
        }

        private int GetSelectedItemId()
        {
            if (ListProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Əməliyyatı tamamlamaq üçün siyahıdan element seçin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            var id = Convert.ToInt32(ListProducts.SelectedItems[0].SubItems[9].Text);
            return id;
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fileName = $"Chixarish{DateTime.Now.Month}.docx";

            var file = DocX.Create(Path.Join(desktop, fileName));
            file.PageLayout.Orientation = Xceed.Document.NET.Orientation.Landscape;

            file.InsertParagraph("Anbardakı malların siyahısı");

            Table mallarCedveli = file.AddTable(Mallar.Count + 1, 8);

            mallarCedveli.Rows[0].Cells[0].Paragraphs.First().Append("No");
            mallarCedveli.Rows[0].Cells[1].Paragraphs.First().Append("Malın adı");
            mallarCedveli.Rows[0].Cells[2].Paragraphs.First().Append("Miqdar");
            mallarCedveli.Rows[0].Cells[3].Paragraphs.First().Append("Alış q.");
            mallarCedveli.Rows[0].Cells[4].Paragraphs.First().Append("Satış q.");
            mallarCedveli.Rows[0].Cells[5].Paragraphs.First().Append("İstehsal t.");
            mallarCedveli.Rows[0].Cells[6].Paragraphs.First().Append("Son istifadə t.");
            mallarCedveli.Rows[0].Cells[7].Paragraphs.First().Append("Yekun qiymət");

            int no = 1;
            foreach (var item in Mallar)
            {
                mallarCedveli.Rows[no].Cells[0].Paragraphs.First().Append((no).ToString());
                mallarCedveli.Rows[no].Cells[1].Paragraphs.First().Append(item.MalAdi);
                mallarCedveli.Rows[no].Cells[2].Paragraphs.First().Append(item.AnbardakiMiqdar.ToString());
                mallarCedveli.Rows[no].Cells[3].Paragraphs.First().Append(((double)item.AlisQiymeti / 100).ToString());
                mallarCedveli.Rows[no].Cells[4].Paragraphs.First().Append(((double)item.SatisQiymeti / 100).ToString());
                mallarCedveli.Rows[no].Cells[5].Paragraphs.First().Append(item.Istehsal.ToShortDateString());
                mallarCedveli.Rows[no].Cells[6].Paragraphs.First().Append(item.SonIstifade.ToShortDateString());
                mallarCedveli.Rows[no].Cells[7].Paragraphs.First().Append(((double)item.YekunQiymet / 100).ToString());
                no++;
            }

            file.InsertTable(mallarCedveli);
            try
            {
                file.Save();
            }
            catch (Exception err)
            {
                MessageBox.Show("Səhv baş verdi. Köhnə faylı bağlayın.");
                MessageBox.Show(err.Message);
            }
        }
    }
}
