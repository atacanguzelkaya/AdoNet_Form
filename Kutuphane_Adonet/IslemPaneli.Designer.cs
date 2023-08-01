namespace Kutuphane_Adonet
{
    partial class IslemPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.cmdAraKitaplar = new System.Windows.Forms.ComboBox();
            this.btnEkleKullanici = new System.Windows.Forms.Button();
            this.btnEkleKitap = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtKullaniciAra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnKitaplar);
            this.panel1.Controls.Add(this.btnKullanici);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitaplar.Location = new System.Drawing.Point(13, 116);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(164, 94);
            this.btnKitaplar.TabIndex = 1;
            this.btnKitaplar.Text = "Kitaplar";
            this.btnKitaplar.UseVisualStyleBackColor = true;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnKullanici
            // 
            this.btnKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanici.Location = new System.Drawing.Point(13, 13);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(164, 96);
            this.btnKullanici.TabIndex = 0;
            this.btnKullanici.Text = "Kullanıcılar";
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guncelle,
            this.Sil});
            this.dataGridView1.Location = new System.Drawing.Point(270, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 347);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Guncelle
            // 
            this.Guncelle.FillWeight = 40F;
            this.Guncelle.HeaderText = "";
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Text = "Guncelle";
            this.Guncelle.UseColumnTextForButtonValue = true;
            this.Guncelle.Width = 60;
            // 
            // Sil
            // 
            this.Sil.FillWeight = 40F;
            this.Sil.HeaderText = "";
            this.Sil.Name = "Sil";
            this.Sil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sil.Text = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            this.Sil.Width = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ara";
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(460, 398);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(311, 20);
            this.TxtAra.TabIndex = 9;
            this.TxtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAra_KeyPress);
            // 
            // cmdAraKitaplar
            // 
            this.cmdAraKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdAraKitaplar.FormattingEnabled = true;
            this.cmdAraKitaplar.Location = new System.Drawing.Point(460, 366);
            this.cmdAraKitaplar.Name = "cmdAraKitaplar";
            this.cmdAraKitaplar.Size = new System.Drawing.Size(184, 26);
            this.cmdAraKitaplar.TabIndex = 17;
            this.cmdAraKitaplar.Text = "Arama kriteri seçiniz.";
            this.cmdAraKitaplar.SelectedIndexChanged += new System.EventHandler(this.cmdAraKitaplar_SelectedIndexChanged);
            // 
            // btnEkleKullanici
            // 
            this.btnEkleKullanici.Location = new System.Drawing.Point(242, 411);
            this.btnEkleKullanici.Name = "btnEkleKullanici";
            this.btnEkleKullanici.Size = new System.Drawing.Size(75, 23);
            this.btnEkleKullanici.TabIndex = 18;
            this.btnEkleKullanici.Text = "Ekle";
            this.btnEkleKullanici.UseVisualStyleBackColor = true;
            this.btnEkleKullanici.Click += new System.EventHandler(this.btnEkleKullanici_Click);
            // 
            // btnEkleKitap
            // 
            this.btnEkleKitap.Location = new System.Drawing.Point(242, 411);
            this.btnEkleKitap.Name = "btnEkleKitap";
            this.btnEkleKitap.Size = new System.Drawing.Size(75, 23);
            this.btnEkleKitap.TabIndex = 19;
            this.btnEkleKitap.Text = "Ekle";
            this.btnEkleKitap.UseVisualStyleBackColor = true;
            this.btnEkleKitap.Click += new System.EventHandler(this.btnEkleKitap_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 366);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(270, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(803, 347);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 40F;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Guncelle";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 60;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.FillWeight = 40F;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "Sil";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 60;
            // 
            // txtKullaniciAra
            // 
            this.txtKullaniciAra.Location = new System.Drawing.Point(460, 397);
            this.txtKullaniciAra.Name = "txtKullaniciAra";
            this.txtKullaniciAra.Size = new System.Drawing.Size(311, 20);
            this.txtKullaniciAra.TabIndex = 22;
            this.txtKullaniciAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAra_KeyPress);
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Adonet.Properties.Resources._61llQ8sTmnL__AC_;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.txtKullaniciAra);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEkleKitap);
            this.Controls.Add(this.btnEkleKullanici);
            this.Controls.Add(this.cmdAraKitaplar);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "IslemPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.ComboBox cmdAraKitaplar;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnKitaplar;
        public System.Windows.Forms.Button btnKullanici;
        public System.Windows.Forms.Button btnEkleKullanici;
        public System.Windows.Forms.Button btnEkleKitap;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.TextBox txtKullaniciAra;
    }
}