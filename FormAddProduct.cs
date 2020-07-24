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
        public FormMalEtrafli()
        {
            InitializeComponent();
            NumericMiqdar.Maximum = int.MaxValue;
            NumericQiymet.Maximum = int.MaxValue;
        }

        public FormMalEtrafli(Mal mal)
        {
            InitializeComponent();

            TextBoxId.Text = mal.Id.ToString();
            TextBoxMalinAdi.Text = mal.MalAdi;
            TextBoxQablasma.Text = mal.Qablasma;
            TextBoxYekun.Text = ((decimal)(mal.BirEdedinQiymeti * mal.Miqdar) / 100).ToString();
            NumericMiqdar.Value = mal.Miqdar;
            NumericMiqdar.Maximum = int.MaxValue;
            NumericQiymet.Value = (decimal)(mal.BirEdedinQiymeti) / 100;
            NumericQiymet.Maximum = int.MaxValue;
            DatePickerIstehsal.Value = mal.Istehsal;
            DatePickerSon.Value = mal.SonIstifade;

            BtnAdd.Text = "Yadda saxla";
            BtnAdd.Click -= new EventHandler(BtnAdd_Click);
            BtnAdd.Click += new EventHandler(BtnAdd_SaveChanges);
            this.Text = "Redaktə et";
        }

        private void NumericMiqdar_ValueChanged(object sender, EventArgs e)
        {
            var miqdar = NumericMiqdar.Value;
            var birEdedinQiymeti = NumericQiymet.Value;

            TextBoxYekun.Text = (miqdar * birEdedinQiymeti).ToString();
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
                Miqdar = (int)(NumericMiqdar.Value),
                Istehsal = DatePickerIstehsal.Value,
                SonIstifade = DatePickerSon.Value,
                BirEdedinQiymeti = (int)(NumericQiymet.Value * 100),
                YekunQiymet = (int)(NumericMiqdar.Value) * (int)(NumericQiymet.Value * 100)
            };

            using var context = new AppDbContext();
            await context.Products.AddAsync(newProduct);

            var result = await context.SaveChangesAsync();
            if (result > 0)
            {
                var form = System.Windows.Forms.Application.OpenForms["FormAnbar"];
                ((FormAnbar)form).RefreshList();
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
                Miqdar = (int)(NumericMiqdar.Value),
                Istehsal = DatePickerIstehsal.Value,
                SonIstifade = DatePickerSon.Value,
                BirEdedinQiymeti = (int)(NumericQiymet.Value * 100),
                YekunQiymet = (int)(NumericMiqdar.Value) * (int)(NumericQiymet.Value * 100)
            };

            using var context = new AppDbContext();
            var old = await context.Products.FirstOrDefaultAsync(p => p.Id == Convert.ToInt32(TextBoxId.Text));
            if (old != null)
            {
                old.Id = Convert.ToInt32(TextBoxId.Text);
                old.MalAdi = TextBoxMalinAdi.Text;
                old.Qablasma = TextBoxQablasma.Text;
                old.Miqdar = (int)(NumericMiqdar.Value);
                old.Istehsal = DatePickerIstehsal.Value;
                old.SonIstifade = DatePickerSon.Value;
                old.BirEdedinQiymeti = (int)(NumericQiymet.Value * 100);
                old.YekunQiymet = (int)(NumericMiqdar.Value) * (int)(NumericQiymet.Value * 100);
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

        private void NumericQiymet_ValueChanged(object sender, EventArgs e)
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
        }
    }
}
