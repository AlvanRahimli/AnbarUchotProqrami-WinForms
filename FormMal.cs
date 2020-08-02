using AnbarUchotu.Data;
using AnbarUchotu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AnbarUchotu
{
    public partial class FormMalEtrafli : Form
    {
        public enum LoadMode
        {
            Add, Details
        }
        public LoadMode OpeningMode { get; set; }
        public Mal Mal { get; set; }

        public FormMalEtrafli()
        {
            InitializeComponent();
            OpeningMode = LoadMode.Add;
        }

        public FormMalEtrafli(Mal mal)
        {
            InitializeComponent();
            OpeningMode = LoadMode.Details;
            Mal = mal;
        }

        private void FormMalEtrafli_Load(object sender, EventArgs e)
        {
            NumericMiqdar.Maximum = int.MaxValue;
            NumericQiymet.Maximum = int.MaxValue;

            switch (OpeningMode)
            {
                case LoadMode.Add:
                    break;
                case LoadMode.Details:
                    TextBoxId.Text = Mal.Id.ToString();
                    TextBoxMalinAdi.Text = Mal.MalAdi;
                    TextBoxQablasma.Text = Mal.Qablasma;
                    TextBoxYekun.Text = ((decimal)(Mal.AlisQiymeti * Mal.AnbardakiMiqdar) / 100).ToString();
                    NumericMiqdar.Value = Mal.AnbardakiMiqdar;
                    NumericQiymet.Value = (decimal)(Mal.AlisQiymeti) / 100;
                    DatePickerIstehsal.Value = Mal.Istehsal;
                    DatePickerSon.Value = Mal.SonIstifade;
                    NumericSatis.Value = (decimal)Mal.SatisQiymeti / 100;

                    BtnAdd.Text = "Yadda saxla";
                    BtnAdd.Click -= new EventHandler(BtnAdd_Click);
                    BtnAdd.Click += new EventHandler(BtnAdd_SaveChanges);
                    Text = "Redaktə et";
                    break;
                default:
                    break;
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxMalinAdi.Text.Trim() == string.Empty || TextBoxQablasma.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Malın adını boş buraxmaq olmaz.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProduct = new Mal()
            {
                MalAdi = TextBoxMalinAdi.Text,
                Qablasma = TextBoxQablasma.Text,
                AnbardakiMiqdar = (int)(NumericMiqdar.Value),
                Istehsal = DatePickerIstehsal.Value,
                SonIstifade = DatePickerSon.Value,
                AlisQiymeti = (int)(NumericQiymet.Value * 100),
                SatisQiymeti = (int)(NumericSatis.Value * 100)
            };

            using var context = new AppDbContext();
            await context.Products.AddAsync(newProduct);

            var result = await context.SaveChangesAsync();
            if (result > 0)
            {
                var form = Application.OpenForms["FormAnbar"];
                var anbarForm = ((FormAnbar)form);
                if (anbarForm != null)
                {
                    anbarForm.RefreshList();
                }
            }

            Thread.Sleep(1000);
            CleanControls();
        }

        private async void BtnAdd_SaveChanges(object sender, EventArgs e)
        {
            var edited = new Mal()
            {
                Id = Convert.ToInt32(TextBoxId.Text),
                MalAdi = TextBoxMalinAdi.Text,
                Qablasma = TextBoxQablasma.Text,
                AnbardakiMiqdar = (int)(NumericMiqdar.Value),
                Istehsal = DatePickerIstehsal.Value,
                SonIstifade = DatePickerSon.Value,
                AlisQiymeti = (int)(NumericQiymet.Value * 100),
                SatisQiymeti = (int)(NumericSatis.Value * 100)
            };

            using var context = new AppDbContext();
            var old = await context.Products.FirstOrDefaultAsync(p => p.Id == Convert.ToInt32(TextBoxId.Text));
            if (old != null)
            {
                old.Id = Convert.ToInt32(TextBoxId.Text);
                old.MalAdi = TextBoxMalinAdi.Text;
                old.Qablasma = TextBoxQablasma.Text;
                old.AnbardakiMiqdar = (int)(NumericMiqdar.Value);
                old.Istehsal = DatePickerIstehsal.Value;
                old.SonIstifade = DatePickerSon.Value;
                old.AlisQiymeti = (int)(NumericQiymet.Value * 100);
                old.SatisQiymeti = (int)(NumericSatis.Value * 100);
            }

            var result = await context.SaveChangesAsync();

            if (result > 0)
            {
                MessageBox.Show("Detallar müvəffəqiyyətlə redaktə olundu.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Səhv baş verdi.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlisaGoreYekun(object sender, EventArgs e)
        {
            var miqdar = (int)NumericMiqdar.Value;
            var birEdedinQiymeti = NumericQiymet.Value;

            TextBoxYekun.Text = (miqdar * birEdedinQiymeti).ToString();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanControls();
        }

        private void CleanControls()
        {
            TextBoxMalinAdi.Clear();
            TextBoxQablasma.Clear();
            TextBoxYekun.Clear();
            NumericMiqdar.Value = 0;
            NumericQiymet.Value = 0;
            DatePickerIstehsal.Value = DateTime.Now;
            DatePickerSon.Value = DateTime.Now;
            NumericSatis.Value = 0;
        }

        private void SatisaGoreYekun(object sender, EventArgs e)
        {
            var miqdar = (int)NumericMiqdar.Value;
            var satisQiymeti = NumericSatis.Value;

            TextBoxYekun.Text = (miqdar * satisQiymeti).ToString();
        }

        private void RadioAlis_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAlis.Checked)
            {
                NumericQiymet.ValueChanged -= new EventHandler(SatisaGoreYekun);
                NumericMiqdar.ValueChanged -= new EventHandler(SatisaGoreYekun);
                NumericSatis.ValueChanged -= new EventHandler(SatisaGoreYekun);

                NumericQiymet.ValueChanged += new EventHandler(AlisaGoreYekun);
                NumericMiqdar.ValueChanged += new EventHandler(AlisaGoreYekun);
                NumericSatis.ValueChanged += new EventHandler(AlisaGoreYekun);

                AlisaGoreYekun(null, null);
            }
        }

        private void RadioSatis_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSatis.Checked)
            {
                NumericQiymet.ValueChanged -= new EventHandler(AlisaGoreYekun);
                NumericMiqdar.ValueChanged -= new EventHandler(AlisaGoreYekun);
                NumericSatis.ValueChanged -= new EventHandler(AlisaGoreYekun);

                NumericQiymet.ValueChanged += new EventHandler(SatisaGoreYekun);
                NumericMiqdar.ValueChanged += new EventHandler(SatisaGoreYekun);
                NumericSatis.ValueChanged += new EventHandler(SatisaGoreYekun);

                SatisaGoreYekun(null, null);
            }
        }
    }
}
