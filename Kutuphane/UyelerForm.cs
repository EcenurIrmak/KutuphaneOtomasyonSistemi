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
    public partial class UyelerForm : Form
    {
        public UyelerForm()
        {
            InitializeComponent();
           
        }

        private void UyelerForm_Load(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = DBHelper.GetData("SELECT * FROM uyeler");
            dgvUyeler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
