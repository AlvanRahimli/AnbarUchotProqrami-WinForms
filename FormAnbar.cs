using AnbarUchotu.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnbarUchotu
{
    public partial class FormAnbar : Form
    {
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

            if (ps.Count > 0)
            {
                int no = 1;
                foreach (var item in ps)
                {
                    string[] cols =
                    {
                        item.MalAdi,
                        item.Qablasma.ToString(),
                        item.Miqdar.ToString(),
                        ((decimal)item.BirEdedinQiymeti / 100).ToString(),
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

                    ListProducts.Items.Add(newItem).SubItems.AddRange(cols);
                    no++;
                }
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Redaktə etmək üçün siyahıdan element seçin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt32(ListProducts.SelectedItems[0].SubItems[8].Text);

            using var context = new AppDbContext();
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

            var formEdit = new FormMalEtrafli(product);
            formEdit.Show();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ListProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silmək üçün siyahıdan element seçin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = Convert.ToInt32(ListProducts.SelectedItems[0].SubItems[8].Text);

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
    }
}
