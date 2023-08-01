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

namespace Kutuphane_Adonet
{
    public partial class KullaniciGuncelle : Form
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true;");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("OGuncelleKullanici", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("KullaniciID", TxtAd.Tag);
            cmd.Parameters.AddWithValue("KullaniciAdSoyad", TxtAd.Text);
            cmd.Parameters.AddWithValue("KullaniciTC", TxtTC.Text);
            cmd.Parameters.AddWithValue("KullaniciMail", TxtMail.Text);
            cmd.Parameters.AddWithValue("KullaniciTelNo", TxtTelNo.Text);
            cmd.Parameters.AddWithValue("AlinanKitap", comboBox1.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKullanici_Click(sender, e);
            this.Close();
        }

        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("KitapKullaniciJoin", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "KitapAdi";
            connection.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKullanici_Click(sender, e);
            this.Close();
        }
    }
}
