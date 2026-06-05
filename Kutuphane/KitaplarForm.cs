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
    public partial class KitaplarForm : Form
    {
        public KitaplarForm()
        {
            InitializeComponent();
        }        
        private void KitaplarForm_Load(object sender, EventArgs e)
        {
            dgvKitaplar.DataSource = DBHelper.GetData("SELECT * FROM vw_kitap_detaylari");
            dgvKitaplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
