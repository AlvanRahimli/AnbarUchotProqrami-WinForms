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
    public partial class FormMusteri : Form
    {
        public enum LoadMode
        {
            Details, Adding
        }

        private int MusteriId { get; set; }
        private Musteri Musteri { get; set; }
        public LoadMode OpeningMode { get; set; }

        public FormMusteri()
        {
            InitializeComponent();
            OpeningMode = LoadMode.Adding;
        }

        public FormMusteri(int id)
        {
            InitializeComponent();
            OpeningMode = LoadMode.Details;
            MusteriId = id;
        }

        private async void FormMusteri_Load(object sender, EventArgs e)
        {
            NumericBorc.Maximum = int.MaxValue;
            NumericSatisSayi.Maximum = int.MaxValue;

            switch (OpeningMode)
            {
                case LoadMode.Details:
                    using (var context = new AppDbContext())
                    {
                        var musteri = await context.Musteriler
                            .AsNoTracking()
                            .Include(m => m.Satislar)
                            .FirstOrDefaultAsync(m => m.Id == MusteriId);

                        if (musteri != null)
                        {
                            Musteri = musteri;

                            TextBoxNo.Text = musteri.Id.ToString();
                            TextBoxMusteriAdi.Text = musteri.Name;
                            TextBoxElaqe.Text = musteri.Elaqe;
                            ComboRayon.Text = musteri.Rayon;
                            NumericBorc.Value = (decimal)musteri.Borc / 100;
                            NumericSatisSayi.Value = musteri.SatisSayi;

                            if (musteri.SatisSayi > 0)
                            {
                                DateSonSatis.Value = musteri.SonSatisTarixi;

                                var ordered = musteri.Satislar.OrderByDescending(s => s.SatisTarixi).ToList();
                                foreach (var satis in musteri.Satislar)
                                {
                                    ComboSatislar.Items.Add($"{satis.SatisTarixi.ToShortDateString()} | {(decimal)satis.CemiQiymet / 100} AZN          |{satis.Id}");
                                    ComboSatislar.SelectedIndex = 0;
                                }
                            }
                            else
                            {
                                DateSonSatis.Value = DateSonSatis.MinDate;
                            }
                        }
                    }
                    ComboSatislar.Enabled = true;
                    BtnSatisEtrafli.Enabled = true;
                    DateSonSatis.Enabled = true;
                    BtnSubmit.Text = "Bağla";
                    Text = "Müştəri haqqında";
                    BtnSubmit.Click -= new EventHandler(BtnSubmit_Click);
                    BtnSubmit.Click += new EventHandler(BtnBagla_Click);
                    break;
                case LoadMode.Adding:
                    CheckRedakte.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ComboRayon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            var newMusteri = new Musteri()
            {
                Name = TextBoxMusteriAdi.Text.Trim(),
                Borc = (int)(NumericBorc.Value * 100),
                Elaqe = TextBoxElaqe.Text,
                Rayon = ComboRayon.Text,
                SatisSayi = 0
            };

            using var context = new AppDbContext();
            await context.Musteriler.AddAsync(newMusteri);

            var dbRes = await context.SaveChangesAsync();
            if (dbRes > 0)
            {
                MessageBox.Show("Müştəri uğurla əlavə olundu.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Səhv baş verdi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSatisEtrafli_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(ComboSatislar.Text.Split('|')[2]);

            var formSatis = new FormSatis(id);
            formSatis.Show();
        }

        private void ComboSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckRedakte_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckRedakte.Checked)
            {
                BtnSubmit.Text = "Yadda saxla";
                BtnSubmit.Click -= new EventHandler(BtnSubmit_Click);
                BtnSubmit.Click -= new EventHandler(BtnBagla_Click);
                BtnSubmit.Click += new EventHandler(BtnYaddaSaxla_Click);
                NumericBorc.Enabled = false;
                NumericSatisSayi.Enabled = false;
                ComboSatislar.Enabled = false;
                DateSonSatis.Enabled = false;
            }
            else if (OpeningMode == LoadMode.Details)
            {
                BtnSubmit.Text = "Bağla";
                BtnSubmit.Click -= new EventHandler(BtnYaddaSaxla_Click);
                BtnSubmit.Click += new EventHandler(BtnBagla_Click);
                NumericBorc.Enabled = true;
                NumericSatisSayi.Enabled = true;
                ComboSatislar.Enabled = true;
                DateSonSatis.Enabled = true;
            }
            else if (OpeningMode == LoadMode.Adding)
            {
                BtnSubmit.Text = "+ Əlavə et";
                BtnSubmit.Click -= new EventHandler(BtnYaddaSaxla_Click);
                BtnSubmit.Click += new EventHandler(BtnSubmit_Click);
                NumericBorc.Enabled = true;
                NumericSatisSayi.Enabled = true;
                ComboSatislar.Enabled = true;
                DateSonSatis.Enabled = true;
            }
        }

        private async void BtnYaddaSaxla_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(TextBoxNo.Text);

            using var context = new AppDbContext();
            var musteri = await context.Musteriler
                .FirstOrDefaultAsync(m => m.Id == id);

            musteri.Name = TextBoxMusteriAdi.Text;
            musteri.Rayon = ComboRayon.Text;
            musteri.Elaqe = TextBoxElaqe.Text;

            var dbRes = await context.SaveChangesAsync();

            if (dbRes > 0)
            {
                MessageBox.Show("Yadda saxlanıldı.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Səhv baş verdi.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
