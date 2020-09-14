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
    public partial class FormSatislar : Form
    {
        public List<Satis> Satislar { get; set; }

        public FormSatislar()
        {
            InitializeComponent();

            using var context = new AppDbContext();
            var satislar = context.Satislar
                .Include(s => s.Musteri)
                .OrderByDescending(s => s.SatisTarixi)
                .ToList();

            Satislar = satislar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formSatis = new FormSatis(GetSelectedItemId());
            formSatis.Show();
        }

        private int GetSelectedItemId()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Əməliyyatı tamamlamaq üçün siyahıdan element seçin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            var id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            return id;
        }

        private void FormSatislar_Load(object sender, EventArgs e)
        {
            foreach (var item in Satislar)
            {
                string[] cols =
                {
                    item.Musteri.Name,
                    item.SatisTarixi.ToShortDateString(),
                    ((decimal)item.CemiQiymet / 100).ToString()
                };

                var newItem = new ListViewItem(item.Id.ToString());

                listView1.Items.Add(newItem).SubItems.AddRange(cols);
            }
        }
    }
}
