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
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true;");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("OGuncelleKitap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("KitapID", TxtKitapAd.Tag);
            cmd.Parameters.AddWithValue("KitapAdi", TxtKitapAd.Text);
            cmd.Parameters.AddWithValue("KitapTuru", TxtKitapTuru.Text);
            cmd.Parameters.AddWithValue("Yazar", TxtYazar.Text);
            cmd.Parameters.AddWithValue("YayinEvi", TxtYayinEvi.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKitaplar_Click(sender, e);
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKitaplar_Click(sender, e);
            this.Close();
        }
    }
}
