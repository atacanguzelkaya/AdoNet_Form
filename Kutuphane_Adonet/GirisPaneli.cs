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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true;");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Personel where PersonelAdi=@PersonelAdi and PersonelSifre=@PersonelSifre", connection);
            cmd.Parameters.AddWithValue("@PersonelAdi", TxtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@PersonelSifre", TxtSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                IslemPaneli islemPaneli = new IslemPaneli();
                islemPaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();

            }
            connection.Close();

        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
