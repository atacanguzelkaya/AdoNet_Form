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

namespace Kutuphane_Adonet
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true;");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("OKaydetKullanici", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("KullaniciAdSoyad", TxtAdSoyad.Text);
            cmd.Parameters.AddWithValue("KullaniciTC", TxtTC.Text);
            cmd.Parameters.AddWithValue("KullaniciMail", TxtMail.Text);
            cmd.Parameters.AddWithValue("KullaniciTelNo", TxtTelno.Text);
            cmd.Parameters.AddWithValue("AlinanKitap", cmbKullanici.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKullanici_Click(sender, e);
            this.Close();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("KitapKullaniciJoin", connection);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbKullanici.DataSource = table;
            cmbKullanici.DisplayMember = "KitapAdi";
            connection.Close();

            // SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar left join Kullanici on Kitaplar.KitapID=Kullanici.KullaniciID where Kullanici.KullaniciID is null", connection);
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
