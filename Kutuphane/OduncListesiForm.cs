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
    public partial class OduncListesiForm : Form
    {
        public OduncListesiForm()
        {
            InitializeComponent();
        }

        private void OduncListesiForm_Load(object sender, EventArgs e)
        {
            dgvOduncListesi.DataSource = DBHelper.GetData("SELECT * FROM vw_odunc_kitaplar");
            dgvOduncListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOduncListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
