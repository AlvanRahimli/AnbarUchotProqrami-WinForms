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
    public partial class FormGelenMallar : Form
    {
        public List<GelenMal> GelenMallar { get; set; }
        public FormGelenMallar()
        {
            InitializeComponent();
        }

        private void FormGelenMallar_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var gelenMallar = context.GelenMallar.AsNoTracking().Include(m => m.Mal).ToList();
            GelenMallar = gelenMallar;

            int no = 1;
            foreach (var item in gelenMallar)
            {
                string[] cols =
                {
                    item.Mal.MalAdi,
                    item.GelenSay.ToString(),
                    item.Date.ToShortDateString()
                };

                var newItem = new ListViewItem(item.Id.ToString());
                
                listView1.Items.Add(newItem).SubItems.AddRange(cols);
                no++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formAdd = new FormMalEtrafli();
            formAdd.Show();
        }
    }
}
