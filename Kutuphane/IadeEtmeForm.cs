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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyonuSistemi
{
    public partial class IadeEtmeForm : Form
    {
        public IadeEtmeForm()
        {
            InitializeComponent();
        }      

        private void IadeEtmeForm_Load(object sender, EventArgs e)
        {
            cbKitap.Enabled = false;
            UyeListele();
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

        private void cbUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUye.SelectedValue == null || cbUye.SelectedValue is DataRowView)
                return;

            cbKitap.Enabled = true;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT
                o.odunc_id,
                k.kitap_adi + ' (Kopya: ' + CAST(kk.kopya_id AS NVARCHAR(10)) + ')' AS kitap
            FROM odunc_almalar o
            INNER JOIN kitap_kopyalari kk ON o.kopya_id = kk.kopya_id
            INNER JOIN kitaplar k ON kk.kitap_id = k.kitap_id
            WHERE o.uye_id = @uye_id
              AND o.iade_tarihi IS NULL", conn);

                da.SelectCommand.Parameters.AddWithValue("@uye_id", cbUye.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbKitap.DataSource = dt;
                cbKitap.DisplayMember = "kitap";
                cbKitap.ValueMember = "odunc_id";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbKitap.SelectedIndex == -1 || cbUye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapın!");
                return;
            }
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_kitap_iade", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@odunc_id", cbKitap.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("İade tamamlandı.");
                this.Close();
            }
        }
    }
}
