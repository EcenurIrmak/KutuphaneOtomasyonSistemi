using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuSistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void buttonUyeler_Click(object sender, EventArgs e)
        {
            new UyelerForm().Show();
        }

        private void buttonKitaplar_Click(object sender, EventArgs e)
        {
            new KitaplarForm().Show();
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            new OduncVerForm().Show();
        }

        private void buttonOduncListesi_Click(object sender, EventArgs e)
        {
            new OduncListesiForm().Show();
        }

        private void buttonUyeEkleme_Click(object sender, EventArgs e)
        {
            new UyeEklemeForm().Show();
        }

        private void buttonIadeEtme_Click(object sender, EventArgs e)
        {
            new IadeEtmeForm().Show();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            new KitapEkleForm().Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
