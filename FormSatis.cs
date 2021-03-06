﻿using AnbarUchotu.Data;
using AnbarUchotu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace AnbarUchotu
{
    public partial class FormSatis : Form
    {
        public enum LoadMode
        {
            Empty, Selected, Details
        }

        public LoadMode OpeningMode { get; set; }
        public int SatisId { get; set; }
        private int[] SecilmisMallar { get; set; }
        private Mal SecilmisMal { get; set; }
        private List<SatilmisMal> Sebet { get; set; }
        private Musteri SecilmisMusteri { get; set; }
        public DateTime SatisTarixi { get; set; }
        private int YekunMebleg
        {
            get
            {
                int c = 0;
                foreach (var mal in Sebet)
                {
                    c += mal.YekunQiymet;
                }
                return c;
            }
        }
        
        public FormSatis()
        {
            InitializeComponent();
            this.OpeningMode = LoadMode.Empty;
            Sebet = new List<SatilmisMal>();
        }

        public FormSatis(int[] secilmisMallar)
        {
            InitializeComponent();
            OpeningMode = LoadMode.Selected;
            SecilmisMallar = secilmisMallar;
        }

        public FormSatis(int satisId)
        {
            InitializeComponent();
            SatisId = satisId;
            OpeningMode = LoadMode.Details;
        }

        private async void FormSatis_Load(object sender, EventArgs e)
        {
            NumericSayi.Maximum = int.MaxValue;
            NumericYekun.Maximum = int.MaxValue;
            button1.Enabled = false;
            await LoadCombos();

            switch (OpeningMode)
            {
                case LoadMode.Empty:
                    SecilmisMallar = new int[0];
                    SatisId = 0;
                    break;
                case LoadMode.Selected:
                    using (var context = new AppDbContext())
                    {
                        var products = await context.Products
                        .Where(p => SecilmisMallar.Contains(p.Id))
                        .Select(p => new SatilmisMal()
                        {
                            MalId = p.Id,
                            SatilanMiqdar = 1,
                            MalAdi = p.MalAdi,
                            Mal = p
                        })
                        .ToListAsync();

                        if (products != null)
                        {
                            Sebet = products;
                            SebetiListeYukle();
                        }
                    }
                    break;
                case LoadMode.Details:
                    using(var context = new AppDbContext())
                    {
                        var satis = await context.Satislar
                            .AsNoTracking()
                            .Include(s => s.Mallar)
                                .ThenInclude(sm => sm.Mal)
                            .Include(s => s.Musteri)
                            .FirstOrDefaultAsync(s => s.Id == SatisId);
                        if (satis != null)
                        {
                            Sebet = satis.Mallar;
                            SecilmisMusteri = satis.Musteri;
                            SecilmisMusteri = satis.Musteri;
                            ComboMusteri.Text = SecilmisMusteri.Name;
                            LblSatilib.Visible = true;
                            SatisTarixi = satis.SatisTarixi;

                            SebetiListeYukle();
                        }
                    }
                    button1.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private async void ComboMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var musteriAdi = ComboMusteri.Text;
            var musteri = await context.Musteriler
                .FirstOrDefaultAsync(m => m.Name == musteriAdi);

            if (musteri != null)
            {
                SecilmisMusteri = musteri;
            }
        }

        private void BtnYeniMal_Click(object sender, EventArgs e)
        {
            var formYeniMal = new FormMalEtrafli();
            formYeniMal.Show();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            var yeniMusteri = new FormMusteri();
            yeniMusteri.Show();
        }

        private async void ComboMal_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var product = await context.Products.FirstOrDefaultAsync(p => p.MalAdi == ComboMal.Text);

            if (product != null)
            {
                LblQablasma.Text = product.Qablasma;
                LblQiymet.Text = ((decimal)product.AlisQiymeti / 100).ToString();
                LblSatis.Text = ((decimal)product.SatisQiymeti / 100).ToString();
                LblSayi.Text = product.AnbardakiMiqdar.ToString();
                LblSonIstifade.Text = product.SonIstifade.ToShortDateString();
                if ((product.SonIstifade - DateTime.Now).Days < 150)
                {
                    LblSonIstifade.ForeColor = Color.White;
                    LblSonIstifade.BackColor = Color.Red;
                }
                else
                {
                    LblSonIstifade.ForeColor = SystemColors.ControlText;
                    LblSonIstifade.BackColor = SystemColors.Control;
                }
                LblIstehsal.Text = product.Istehsal.ToShortDateString();

                SecilmisMal = product;
                NumericSayi.Value = 0;
                NumericYekun.Value = 0;
                NumericSayi.Enabled = true;
                NumericYekun.Enabled = true;

                if (product.AnbardakiMiqdar == 0)
                    BtnSebeteAt.Enabled = false;
                else
                    BtnSebeteAt.Enabled = true;
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)NumericSayi.Value > SecilmisMal.AnbardakiMiqdar)
                {
                    NumericSayi.Value = SecilmisMal.AnbardakiMiqdar;
                    MessageBox.Show("Satılan miqdar anbarda olandan çox ola bilməz.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    NumericYekun.Value = (decimal)SecilmisMal.SatisQiymeti / 100 * NumericSayi.Value;
            }
            catch { }
        }

        private void BtnSebeteAt_Click(object sender, EventArgs e)
        {
            if (NumericSayi.Value == 0)
            {
                MessageBox.Show("Malın sayı qeyd olunmayıb.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sebet.Add(new SatilmisMal() 
            {
                MalId = SecilmisMal.Id,
                MalAdi = SecilmisMal.MalAdi,
                SatilanMiqdar = (int)NumericSayi.Value,
                Mal = SecilmisMal
            });

            LblYekun.Text = ((decimal)YekunMebleg / 100).ToString();
            SebetiListeYukle();
            LblSatilib.Visible = false;
            BtnSat.Enabled = true;
        }

        public async Task LoadCombos()
        {
            ComboMusteri.Items.Clear();
            ComboMal.Items.Clear();

            using var context = new AppDbContext();
            var products = await context.Products
                .AsNoTracking()

                .OrderBy(p => p.MalAdi)
                .ToListAsync();
            foreach (var p in products)
            {
                ComboMal.Items.Add(p.MalAdi);
            }

            var musteriler = await context.Musteriler.ToListAsync();
            foreach (var musteri in musteriler)
            {
                ComboMusteri.Items.Add(musteri.Name);
            }
        }

        private void SebetiListeYukle()
        {
            LblYekun.Text = ((decimal)YekunMebleg / 100).ToString();
            ListSecilmisMallar.Items.Clear();
            foreach (var p in Sebet)
            {
                string itemText = $"{p.MalAdi}- {p.SatilanMiqdar} ədəd (cəmi: {(decimal)p.YekunQiymet / 100} AZN)";
                ListSecilmisMallar.Items.Add(itemText);
            }
        }

        private async void BtnMusteriYenile_Click(object sender, EventArgs e)
        {
            ComboMusteri.Items.Clear();

            using var context = new AppDbContext();
            var musteriler = await context.Musteriler.ToListAsync();
            foreach (var musteri in musteriler)
            {
                ComboMusteri.Items.Add(musteri.Name);
            }
        }

        private async void BtnMalYenile_Click(object sender, EventArgs e)
        {
            ComboMal.Items.Clear();

            using var context = new AppDbContext();
            var products = await context.Products
                .AsNoTracking()
                .OrderBy(p => p.MalAdi)
                .ToListAsync();
            foreach (var p in products)
            {
                ComboMal.Items.Add(p.MalAdi);
            }
        }

        private async void BtnSebetdenSil_Click(object sender, EventArgs e)
        {
            if (ListSecilmisMallar.SelectedItem == null)
                return;

            var selectedItem = ListSecilmisMallar.SelectedItem.ToString();
            var malinAdi = selectedItem.Split('-')[0];

            using var context = new AppDbContext();
            var mal = await context.Products.FirstOrDefaultAsync(p => p.MalAdi == malinAdi);
            if (mal != null)
            {
                var silinecekMal = Sebet.FirstOrDefault(m => m.MalId == mal.Id);
                if (silinecekMal != null)
                {
                    Sebet.Remove(silinecekMal);
                    SebetiListeYukle();
                    LblYekun.Text = ((decimal)YekunMebleg / 100).ToString();
                }
            }
            else
            {
                MessageBox.Show("Səhv baş verdi", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEtrafliMusteri_Click(object sender, EventArgs e)
        {
            if (SecilmisMusteri != null)
            {
                var formMusteri = new FormMusteri(SecilmisMusteri.Id);
                formMusteri.Show();
            }
        }

        private async void BtnSat_Click(object sender, EventArgs e)
        {
            if (Sebet.Count == 0)
            {
                MessageBox.Show("Səbət boşdur", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ComboMusteri.SelectedIndex < 0)
            {
                MessageBox.Show("Müştəri seçilməyib", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string summary = $"Yekun: {(decimal)YekunMebleg / 100} AZN\n"
                           + $"Müştəri: {SecilmisMusteri.Name}\n"
                           + $"Mallar:\n";
            foreach (var mal in Sebet)
            {
                summary += $"    >{mal.MalAdi} | {mal.SatilanMiqdar} ədəd (cəmi: {(decimal)mal.YekunQiymet / 100}) AZN\n";
            }

            var desicion = MessageBox.Show(summary + "\nDavam etmək istəyirsiniz?", "Bildiriş", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (desicion == DialogResult.No)
            {
                MessageBox.Show("Satış təsdiqlənmədi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yekun = 0;
            foreach (var m in Sebet)
            {
                yekun += m.YekunQiymet;
            }

            using var context = new AppDbContext();
            var yeniSatis = new Satis()
            {
                SatisTarixi = DateTime.Now,
                MusteriId = SecilmisMusteri.Id,
                CemiQiymet = yekun
            };
            await context.Satislar.AddAsync(yeniSatis);
            await context.SaveChangesAsync();
            var satis = await context.Satislar
                .FirstOrDefaultAsync(s => s.SatisTarixi == yeniSatis.SatisTarixi);

            var musteri = await context.Musteriler
                .FirstOrDefaultAsync(m => m.Id == SecilmisMusteri.Id);
            musteri.Borc += satis.CemiQiymet;
            musteri.SatisSayi += 1;
                
            foreach (var sebetdekiMal in Sebet)
            {
                var satilmisMal = new SatilmisMal()
                {
                    MalId = sebetdekiMal.MalId,
                    MalAdi = sebetdekiMal.MalAdi,
                    SatilanMiqdar = sebetdekiMal.SatilanMiqdar,
                    SatisId = satis.Id,
                    Mal = await context.Products.FirstOrDefaultAsync(m => m.Id == sebetdekiMal.MalId)
                };

                await context.SatilmisMallar.AddAsync(satilmisMal);

                var anbardakiMal = await context.Products
                    .FirstOrDefaultAsync(anbardaki => anbardaki.Id == sebetdekiMal.MalId);

                if (anbardakiMal != null)
                {
                    anbardakiMal.AnbardakiMiqdar -= sebetdekiMal.SatilanMiqdar;
                }
            }
            var dbRes = await context.SaveChangesAsync();

            if (dbRes > 0)
            {
                MessageBox.Show("Satış həyata keçirildi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblSatilib.Visible = true;
                BtnSat.Enabled = false;

                // TODO: Qaime yarat
                var qaime = QaimeYarat();
                if (qaime == true)
                {
                    MessageBox.Show("Qaimə yaradıldı");
                }
                else
                {
                    MessageBox.Show("Qaimə yaradılarkən səhv baş verdi");
                }
            }
            else
            {
                MessageBox.Show("Satışı həyata keçirilərkən səhv baş verdi", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool QaimeYarat()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fileName = $"Qaime-{SecilmisMusteri.Name} {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.docx";

            var file = DocX.Create(Path.Join(desktop, fileName));
            file.SetDefaultFont(new Xceed.Document.NET.Font("Times new roman"), 14D, Color.Black);

            // TITLE:
            Formatting titleFormat = new Formatting
            {
                //Specify font family  
                FontFamily = new Xceed.Document.NET.Font("Arial"),
                Size = 20D,
                Position = 40,
                FontColor = Color.Black,
                Bold = true
            };
            var header = file.InsertParagraph("QAIMƏ - No:", false, titleFormat);
            header.Alignment = Alignment.center;

            // TARIX:
            if (OpeningMode == LoadMode.Details)
            {
                var _ = file.InsertParagraph($"Tarix: {SatisTarixi:dd/MM/yyyy}");
            }
            else
            {
                var _ = file.InsertParagraph($"Tarix: {DateTime.Now:dd/MM/yyyy}");
            }

            // KIME
            var _8 = file.InsertParagraph($"Kimə: {SecilmisMusteri.Name}");

            // KIMDEN
            var _7 = file.InsertParagraph($"Kimdən: _____________________");

            // SPACING
            file.InsertParagraph("");
            file.InsertParagraph("");

            // CEDVEL
            Table mallarCedveli = file.AddTable(Sebet.Count + 1, 6);

            mallarCedveli.Rows[0].Cells[0].Paragraphs.First().Append("No");
            mallarCedveli.Rows[0].Cells[1].Paragraphs.First().Append("Malın adı");
            mallarCedveli.Rows[0].Cells[2].Paragraphs.First().Append("Qablaşma");
            mallarCedveli.Rows[0].Cells[3].Paragraphs.First().Append("Miqdar (ədəd)");
            mallarCedveli.Rows[0].Cells[4].Paragraphs.First().Append("Qiymət (manat)");
            mallarCedveli.Rows[0].Cells[5].Paragraphs.First().Append("Cəmi (manat)");

            int no = 1;
            foreach (var item in Sebet)
            {
                mallarCedveli.Rows[no].Cells[0].Paragraphs.First().Append(no.ToString());
                mallarCedveli.Rows[no].Cells[1].Paragraphs.First().Append(item.MalAdi);
                mallarCedveli.Rows[no].Cells[2].Paragraphs.First().Append(item.Mal.Qablasma);
                mallarCedveli.Rows[no].Cells[3].Paragraphs.First().Append(item.SatilanMiqdar.ToString());
                mallarCedveli.Rows[no].Cells[4].Paragraphs.First().Append(((double)item.Mal.SatisQiymeti / 100).ToString());
                mallarCedveli.Rows[no].Cells[5].Paragraphs.First().Append(((double)(item.Mal.SatisQiymeti * item.SatilanMiqdar) / 100).ToString());

                no++;
            }
            file.InsertTable(mallarCedveli);

            // CEMI
            var _1 = file.InsertParagraph($"Cəmi: {(double)YekunMebleg / 100} AZN");

            file.InsertParagraph("");

            
            var _2 = file.InsertParagraph($"Köhnə borc: {(double)SecilmisMusteri.Borc / 100}");
            // KOHNE BORC
            
            file.InsertParagraph("");
            file.InsertParagraph("");

            // ODENIS
            var _3 = file.InsertParagraph($"Ödəniş: ______ AZN");

            // YEKUN BORC
            var _4 = file.InsertParagraph($"Yekun borc: ______ AZN");

            // TEHVIL 
            var _5 = file.InsertParagraph($"Təhvil verdi: ______________________");
            var _6 = file.InsertParagraph($"Təhvil aldı: ______________________");


            try
            {
                file.Save();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Səhv baş verdi. Köhnə faylı bağlayın.");
                MessageBox.Show(err.Message);
                return false;
            }
        }

        private async void ListSecilmisMallar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSecilmisMallar.SelectedItem == null)
                return;

            var selectedItem = ListSecilmisMallar.SelectedItem.ToString();
            var malinAdi = selectedItem.Split('-')[0];

            using var context = new AppDbContext();
            var mal = await context.Products.FirstOrDefaultAsync(p => p.MalAdi == malinAdi);
            if (mal != null)
            {
                LblQablasma.Text = mal.Qablasma;
                LblQiymet.Text = ((decimal)mal.AlisQiymeti / 100).ToString();
                LblSatis.Text = ((decimal)mal.SatisQiymeti / 100).ToString();
                LblSayi.Text = mal.AnbardakiMiqdar.ToString();
                LblSonIstifade.Text = mal.SonIstifade.ToShortDateString();
                LblIstehsal.Text = mal.Istehsal.ToShortDateString();
                if ((mal.SonIstifade - DateTime.Now).Days < 150)
                {
                    LblSonIstifade.ForeColor = Color.White;
                    LblSonIstifade.BackColor = Color.Red;
                }
                else
                {
                    LblSonIstifade.ForeColor = SystemColors.ControlText;
                    LblSonIstifade.BackColor = SystemColors.Control;
                }

                NumericSayi.Enabled = false;
                NumericYekun.Enabled = false;
                NumericSayi.Enabled = true;
                NumericYekun.Enabled = true;
            }
            else
            {
                MessageBox.Show("Səhv baş verdi", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QaimeYarat();
        }
    }
}
