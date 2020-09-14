using AnbarUchotu.Data;
using AnbarUchotu.Models;
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
    public partial class FormMusteri_siyahisi : Form
    {
        public List<Musteri> Musteriler { get; set; }
        public FormMusteri_siyahisi()
        {
            InitializeComponent();

            using var context = new AppDbContext();
            var musteriler = context.Musteriler
                .Include(m => m.Satislar).ToList();
            Musteriler = musteriler;
        }

        private void FormMusteri_siyahisi_DoubleClick(object sender, EventArgs e)
        {

        }

        private int GetSelectedItemId()
        {
            if (musterilerList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Əməliyyatı tamamlamaq üçün siyahıdan element seçin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            var id = Convert.ToInt32(musterilerList.SelectedItems[0].Text);
            return id;
        }

        private void FormMusteri_siyahisi_Load(object sender, EventArgs e)
        {
            foreach (var item in Musteriler)
            {
                string[] cols =
                {
                    item.Name,
                    item.Rayon,
                    ((decimal)item.Borc / 100).ToString(),
                    item.SonSatisTarixi.ToShortDateString(),
                    item.Elaqe,
                    item.SatisSayi.ToString()
                };

                var newItem = new ListViewItem(item.Id.ToString());

                musterilerList.Items.Add(newItem).SubItems.AddRange(cols);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var musteriForm = new FormMusteri(GetSelectedItemId());
            musteriForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formOdenis = new FormOdenis(GetSelectedItemId());
            formOdenis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var musteriler = context.Musteriler
                .Include(m => m.Satislar).ToList();
            Musteriler = musteriler;

            musterilerList.Items.Clear();
            foreach (var item in Musteriler)
            {
                string[] cols =
                {
                    item.Name,
                    item.Rayon,
                    ((decimal)item.Borc / 100).ToString(),
                    item.SonSatisTarixi.ToShortDateString(),
                    item.Elaqe,
                    item.SatisSayi.ToString()
                };

                var newItem = new ListViewItem(item.Id.ToString());

                musterilerList.Items.Add(newItem).SubItems.AddRange(cols);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formYeniMusteri = new FormMusteri();
            formYeniMusteri.Show();
        }
    }
}
