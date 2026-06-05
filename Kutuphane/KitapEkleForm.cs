using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuSistemi
{
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Tüm alanları doldurun!");
                    return;
                }
            }
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_kitap_ekle", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@kitap_adi", txtKitap.Text);
                cmd.Parameters.AddWithValue("@isbn", txtIsbn.Text);
                cmd.Parameters.AddWithValue("@yazar_ad", txtYazAd.Text);
                cmd.Parameters.AddWithValue("@yazar_soyad", txtYazSoyad.Text);
                cmd.Parameters.AddWithValue("@yayinevi_adi", txtYayinevi.Text);
                cmd.Parameters.AddWithValue("@kategori_adi", txtKategori.Text);
                cmd.Parameters.AddWithValue("@yayin_yili", Convert.ToInt32(txtYil.Text));
                cmd.Parameters.AddWithValue("@kopya_sayisi", Convert.ToInt32(txtKopyaSayisi.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kitap başarıyla eklendi.");
            this.Close();
        }
    

    }
    
}
