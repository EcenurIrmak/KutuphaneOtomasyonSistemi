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
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            UyeListele();
            KitapListele();
            cbKopya.Enabled = false;
            dtAlis.Value = DateTime.Today;
            dtTeslim.Value = dtAlis.Value.AddMonths(1);
        }
        private void UyeListele()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT uye_id, ad + ' ' + soyad AS ad_soyad FROM uyeler", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbUye.DataSource = dt;
                cbUye.DisplayMember = "ad_soyad";
                cbUye.ValueMember = "uye_id";
            }
        }
        private void KitapListele()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT kitap_id, kitap_adi FROM kitaplar", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbKitap.DataSource = dt;
                cbKitap.DisplayMember = "kitap_adi";
                cbKitap.ValueMember = "kitap_id";
            }
        }
        private void dtAlis_ValueChanged(object sender, EventArgs e)
        {
            dtTeslim.Value = dtAlis.Value.AddMonths(1);
        }

        private void cbKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKitap.SelectedValue == null || cbKitap.SelectedValue is DataRowView)
                return;

            cbKopya.Enabled = true;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT kopya_id FROM kitap_kopyalari WHERE kitap_id = @kitap_id AND durum = 'Müsait'", conn);

                da.SelectCommand.Parameters.AddWithValue("@kitap_id", cbKitap.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbKopya.DataSource = dt;
                cbKopya.DisplayMember = "kopya_id";
                cbKopya.ValueMember = "kopya_id";
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbKitap.SelectedIndex == -1 || cbUye.SelectedIndex == -1 || cbKopya.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapın!");
                return;
            }
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_kitap_odunc_ver", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@uye_id", cbUye.SelectedValue);
                cmd.Parameters.AddWithValue("@kopya_id", cbKopya.SelectedValue);
                cmd.Parameters.AddWithValue("@alis_tarihi", dtAlis.Value);
                cmd.Parameters.AddWithValue("@son_teslim_tarihi", dtTeslim.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kitap ödünç verildi.");
                this.Close();
            }
        }
    }
}
