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
    public partial class FormOdenis : Form
    {
        public int Id { get; set; }
        public FormOdenis(int id)
        {
            InitializeComponent();

            this.Id = id;
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var musteri = context.Musteriler.FirstOrDefault(m => m.Id == Id);

            if (musteri != null)
                musteri.Borc -= (int)(numericUpDown1.Value * 100);

            var res = context.SaveChanges();
            if (res > 0)
            {
                MessageBox.Show($"Ödəniş əlavə olundu. \nQalıq: {(double)musteri.Borc / 100}", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Səhv baş verdi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
