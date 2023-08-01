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
    public partial class KitapSil : Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true");
        private void BtnEvet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("OKullaniciKitapGuncelle", connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("KitapID", label1.Tag);
            cmd2.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd = new SqlCommand("OSilKitap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("KitapID", label1.Tag);
            cmd.ExecuteNonQuery();
            connection.Close();
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKitaplar_Click(sender, e);
            this.Close();
        }

        private void BtnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
