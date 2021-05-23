
namespace EntityOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDersID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnProsedür = new System.Windows.Forms.Button();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(13, 258);
            this.BtnOgrenciListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(200, 36);
            this.BtnOgrenciListele.TabIndex = 0;
            this.BtnOgrenciListele.Text = "Öğrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(13, 299);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(200, 36);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(13, 341);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(200, 36);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(13, 382);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(200, 36);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(13, 425);
            this.BtnBul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(200, 36);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Location = new System.Drawing.Point(13, 468);
            this.BtnDersListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(200, 36);
            this.BtnDersListesi.TabIndex = 6;
            this.BtnDersListesi.Text = "Ders Listesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(13, 509);
            this.BtnNotListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(200, 36);
            this.BtnNotListesi.TabIndex = 7;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrenciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(241, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(346, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(136, 156);
            this.TxtFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(185, 30);
            this.TxtFoto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(136, 120);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(185, 30);
            this.TxtSoyad.TabIndex = 5;
            this.TxtSoyad.TextChanged += new System.EventHandler(this.TxtSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYAD:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(136, 84);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(185, 30);
            this.TxtAd.TabIndex = 3;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // TxtOgrenciID
            // 
            this.TxtOgrenciID.Location = new System.Drawing.Point(136, 48);
            this.TxtOgrenciID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtOgrenciID.Name = "TxtOgrenciID";
            this.TxtOgrenciID.Size = new System.Drawing.Size(185, 30);
            this.TxtOgrenciID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDersAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDersID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(241, 482);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(346, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(136, 69);
            this.TxtDersAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(185, 30);
            this.TxtDersAd.TabIndex = 3;
            this.TxtDersAd.TextChanged += new System.EventHandler(this.TxtDersAd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "AD:";
            // 
            // TxtDersID
            // 
            this.TxtDersID.Location = new System.Drawing.Point(136, 32);
            this.TxtDersID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDersID.Name = "TxtDersID";
            this.TxtDersID.Size = new System.Drawing.Size(185, 30);
            this.TxtDersID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnJoin);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtOrtalama);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(602, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(386, 322);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(78, 266);
            this.BtnJoin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(240, 36);
            this.BtnJoin.TabIndex = 11;
            this.BtnJoin.Text = "Join ile Getir";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(78, 222);
            this.BtnHesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(240, 36);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(140, 170);
            this.TxtDurum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(228, 30);
            this.TxtDurum.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "DURUM:";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(140, 137);
            this.TxtOrtalama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(228, 30);
            this.TxtOrtalama.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ORTALAMA:";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(140, 101);
            this.TxtSinav3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(228, 30);
            this.TxtSinav3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "SINAV 3:";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(140, 65);
            this.TxtSinav2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(228, 30);
            this.TxtSinav2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "SINAV 2:";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(140, 30);
            this.TxtSinav1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(228, 30);
            this.TxtSinav1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "SINAV 1:";
            // 
            // BtnProsedür
            // 
            this.BtnProsedür.Location = new System.Drawing.Point(13, 555);
            this.BtnProsedür.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnProsedür.Name = "BtnProsedür";
            this.BtnProsedür.Size = new System.Drawing.Size(200, 36);
            this.BtnProsedür.TabIndex = 11;
            this.BtnProsedür.Text = "Not Listesi Prosedür";
            this.BtnProsedür.UseVisualStyleBackColor = true;
            this.BtnProsedür.Click += new System.EventHandler(this.BtnProsedür_Click);
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(1034, 555);
            this.BtnLinqEntity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(224, 37);
            this.BtnLinqEntity.TabIndex = 13;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1006, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(224, 29);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala (A-Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1006, 64);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(224, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala (Z-A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1006, 99);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(206, 29);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ada Göre İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1006, 134);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(137, 29);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5. ID\'yi Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1006, 169);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(178, 29);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A ile Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1006, 205);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(141, 29);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "A ile Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(1006, 239);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(158, 29);
            this.radioButton7.TabIndex = 20;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var mı?";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(1006, 274);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(231, 29);
            this.radioButton8.TabIndex = 21;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Toplam Öğrenci Sayısı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(1006, 309);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(221, 29);
            this.radioButton9.TabIndex = 22;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sınav 1 Toplam Puan";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(1006, 344);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(235, 29);
            this.radioButton10.TabIndex = 23;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav 1 Ortalama Puan";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(1006, 380);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(239, 29);
            this.radioButton11.TabIndex = 24;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "En Yüksek Sınav1 Notu";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(1006, 414);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(230, 29);
            this.radioButton12.TabIndex = 25;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "En Düşük Sınav1 Notu";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(1006, 449);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(307, 29);
            this.radioButton13.TabIndex = 26;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "S1 Notu Ortdan Yüksek Olanlar";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(1006, 484);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(282, 29);
            this.radioButton14.TabIndex = 27;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "En Yüksek Sınav Notu Kimin";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 632);
            this.Controls.Add(this.radioButton14);
            this.Controls.Add(this.radioButton13);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.BtnProsedür);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.BtnDersListesi);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDersID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnProsedür;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
    }
}

