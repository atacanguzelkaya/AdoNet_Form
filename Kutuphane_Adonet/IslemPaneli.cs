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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-5MF5L1H;database=Kutuphane;integrated security=true;");
        string ara;

        public void Listeleme(string sorgu)

        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void Listeleme2(string sorgu)

        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label4.Visible = false;
            TxtAra.Visible = false;
            cmdAraKitaplar.Visible = false;
            btnEkleKitap.Visible = false;
            btnEkleKullanici.Visible = false;
            comboBox1.Visible = false;
            txtKullaniciAra.Visible=false;

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmdAraKitaplar.DataSource = table;
            cmdAraKitaplar.DisplayMember = "KitapTuru";

            ////----------------
            //SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Kullanici", connection);
            //DataTable table1 = new DataTable();
            //adapter1.Fill(table1);
            //CmdAraKullanici.DataSource = table1;
            //CmdAraKullanici.DisplayMember = "KullaniciAdSoyad";


        }
        public void btnKullanici_Click(object sender, EventArgs e)
        {
            btnEkleKitap.Visible = false;
            btnEkleKullanici.Visible = true;
            TxtAra.Visible = false;
            txtKullaniciAra.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            label4.Visible = true;
            cmdAraKitaplar.Visible = false;
            comboBox1.Visible = false;
            Listeleme("Select * from Kullanici");
        }
        public void btnKitaplar_Click(object sender, EventArgs e)
        {
            btnEkleKullanici.Visible = false;
            btnEkleKitap.Visible = true;
            TxtAra.Visible = true;
            label4.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            cmdAraKitaplar.Visible = true;
            comboBox1.Visible = true;
            txtKullaniciAra.Visible = false;
            Listeleme2("Select * from Kitaplar");
        }
        private void btnEkleKullanici_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.Show();
            this.Hide();
        }

        private void btnEkleKitap_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Hide();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if (e.ColumnIndex == 0)
            {
                KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
                kullaniciGuncelle.Show();
                kullaniciGuncelle.TxtAd.Tag = satir.Cells["KullaniciID"].Value.ToString();
                kullaniciGuncelle.TxtAd.Text = satir.Cells["KullaniciAdSoyad"].Value.ToString();
                kullaniciGuncelle.TxtTC.Text = satir.Cells["KullaniciTC"].Value.ToString();
                kullaniciGuncelle.TxtMail.Text = satir.Cells["KullaniciMail"].Value.ToString();
                kullaniciGuncelle.TxtTelNo.Text = satir.Cells["KullaniciTelNo"].Value.ToString();
                
                this.Hide();
            }
            if (e.ColumnIndex == 1)
            {
                KullaniciSil kullaniciSil = new KullaniciSil();
                kullaniciSil.Show();
                kullaniciSil.label1.Tag = satir.Cells["KullaniciID"].Value.ToString();
                kullaniciSil.label1.Text = satir.Cells["KullaniciAdSoyad"].Value.ToString();
                this.Hide();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView2.CurrentRow;
            if (e.ColumnIndex == 0)
            {
                KitapGuncelle kitapGuncelle = new KitapGuncelle();
                kitapGuncelle.Show();
                kitapGuncelle.TxtKitapAd.Tag = satir.Cells["KitapID"].Value.ToString();
                kitapGuncelle.TxtKitapAd.Text = satir.Cells["KitapAdi"].Value.ToString();
                kitapGuncelle.TxtKitapTuru.Text = satir.Cells["KitapTuru"].Value.ToString();
                kitapGuncelle.TxtYazar.Text = satir.Cells["Yazar"].Value.ToString();
                kitapGuncelle.TxtYayinEvi.Text = satir.Cells["YayinEvi"].Value.ToString();
                this.Hide();
            }
            if (e.ColumnIndex == 1)
            {
                KitapSil kitapsil = new KitapSil();
                kitapsil.Show();
                kitapsil.label1.Tag = satir.Cells["KitapID"].Value.ToString();
                kitapsil.label1.Text = satir.Cells["KitapAdi"].Value.ToString();
                this.Hide();
            }
        }

        private void cmdAraKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Tag = cmdAraKitaplar.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar where KitapTuru='" + comboBox1.Tag + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "KitapAdi";
            dataGridView2.DataSource = table;
        }

        private void TxtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Kitaplar where KitapAdi like '%"+TxtAra.Text+ "%'OR KitapTuru like '%" + TxtAra.Text + "%' OR Yazar like '%" + TxtAra.Text +"%' OR YayinEvi like '%" + TxtAra.Text +"%'", connection);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void txtKullaniciAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Kullanici where KullaniciAdSoyad like '%" +txtKullaniciAra.Text + "%' OR KullaniciTC like '%" +txtKullaniciAra.Text + "%' OR KullaniciMail like '%" +txtKullaniciAra.Text + "%' OR KullaniciTelNo like '%" +txtKullaniciAra.Text + "%'OR AlinanKitap like '%" +txtKullaniciAra.Text +"%'", connection);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
