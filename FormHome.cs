using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnbarUchotu
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void BtnAnbar_Click(object sender, EventArgs e)
        {
            var formAnbar = new FormAnbar();
            formAnbar.Show();
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
            var formSatis = new FormSatis();
            formSatis.Show();
        }

        private void BtnMusteriSiyahisi_Click(object sender, EventArgs e)
        {
            var formMusteriler = new FormMusteri_siyahisi();
            formMusteriler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formSatislar = new FormSatislar();
            formSatislar.Show();
        }

        private void BtnGelen_mal_Click(object sender, EventArgs e)
        {
            var formGelenler = new FormGelenMallar();
            formGelenler.Show();
        }
    }
}
