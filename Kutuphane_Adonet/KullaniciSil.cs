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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true");
        private void BtnEvet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("OSilKullanici", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("KullaniciID", label1.Tag);
            cmd.ExecuteNonQuery();
            connection.Close();
            IslemPaneli islemPaneli = new IslemPaneli();
            islemPaneli.Show();
            islemPaneli.btnKullanici_Click(sender, e);
            this.Close();
        }

        private void BtnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
