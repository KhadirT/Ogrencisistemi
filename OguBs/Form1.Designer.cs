namespace OgrenciBilgiSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer oluşturulan kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.btnSecimOnayla = new System.Windows.Forms.Button();
            this.pnlOgrenci = new System.Windows.Forms.Panel();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.cmbGuncelle = new System.Windows.Forms.ComboBox();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.pnlOgretmen = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.ogrenciDersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDurumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciYonetimDataSet = new OguBs.OgrenciYonetimDataSet();
            this.pnlMemur = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.btnDersOgrencileriListele = new System.Windows.Forms.Button();
            this.btnDersGuncelleMemur = new System.Windows.Forms.Button();
            this.btnDersSilMemur = new System.Windows.Forms.Button();
            this.btnDersEkleMemur = new System.Windows.Forms.Button();
            this.txtHocaAdi = new System.Windows.Forms.TextBox();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtOgrenciGNO = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.ogrenciDersTableAdapter = new OguBs.OgrenciYonetimDataSetTableAdapters.OgrenciDersTableAdapter();
            this.ogrenciTableAdapter = new OguBs.OgrenciYonetimDataSetTableAdapters.OgrenciTableAdapter();
            this.txtKontenjan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlOgrenci.SuspendLayout();
            this.pnlOgretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).BeginInit();
            this.pnlMemur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSecim
            // 
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen",
            "Öğrenci İşleri"});
            this.cmbSecim.Location = new System.Drawing.Point(12, 21);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(121, 24);
            this.cmbSecim.TabIndex = 0;
            // 
            // btnSecimOnayla
            // 
            this.btnSecimOnayla.Location = new System.Drawing.Point(157, 21);
            this.btnSecimOnayla.Name = "btnSecimOnayla";
            this.btnSecimOnayla.Size = new System.Drawing.Size(107, 23);
            this.btnSecimOnayla.TabIndex = 1;
            this.btnSecimOnayla.Text = "Seçimi Onayla";
            this.btnSecimOnayla.UseVisualStyleBackColor = true;
            this.btnSecimOnayla.Click += new System.EventHandler(this.btnSecimOnayla_Click);
            // 
            // pnlOgrenci
            // 
            this.pnlOgrenci.Controls.Add(this.btnDersKaydet);
            this.pnlOgrenci.Controls.Add(this.btnDersGuncelle);
            this.pnlOgrenci.Controls.Add(this.cmbGuncelle);
            this.pnlOgrenci.Controls.Add(this.btnDersSil);
            this.pnlOgrenci.Controls.Add(this.lstDersler);
            this.pnlOgrenci.Controls.Add(this.btnDersEkle);
            this.pnlOgrenci.Controls.Add(this.cmbDersler);
            this.pnlOgrenci.Location = new System.Drawing.Point(12, 97);
            this.pnlOgrenci.Name = "pnlOgrenci";
            this.pnlOgrenci.Size = new System.Drawing.Size(233, 341);
            this.pnlOgrenci.TabIndex = 2;
            this.pnlOgrenci.Visible = false;
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(129, 189);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(104, 23);
            this.btnDersKaydet.TabIndex = 9;
            this.btnDersKaydet.Text = "Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(127, 240);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(103, 23);
            this.btnDersGuncelle.TabIndex = 8;
            this.btnDersGuncelle.Text = "Ders Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // cmbGuncelle
            // 
            this.cmbGuncelle.FormattingEnabled = true;
            this.cmbGuncelle.Location = new System.Drawing.Point(0, 240);
            this.cmbGuncelle.Name = "cmbGuncelle";
            this.cmbGuncelle.Size = new System.Drawing.Size(121, 24);
            this.cmbGuncelle.TabIndex = 7;
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(129, 141);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(101, 23);
            this.btnDersSil.TabIndex = 6;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.ItemHeight = 16;
            this.lstDersler.Location = new System.Drawing.Point(3, 96);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(120, 116);
            this.lstDersler.TabIndex = 5;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(145, 28);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 4;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // cmbDersler
            // 
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(3, 27);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(121, 24);
            this.cmbDersler.TabIndex = 3;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDersler_SelectedIndexChanged);
            // 
            // pnlOgretmen
            // 
            this.pnlOgretmen.Controls.Add(this.btnYenile);
            this.pnlOgretmen.Controls.Add(this.btnReddet);
            this.pnlOgretmen.Controls.Add(this.btnOnayla);
            this.pnlOgretmen.Controls.Add(this.dgvOgrenciler);
            this.pnlOgretmen.Location = new System.Drawing.Point(269, 97);
            this.pnlOgretmen.Name = "pnlOgretmen";
            this.pnlOgretmen.Size = new System.Drawing.Size(256, 341);
            this.pnlOgretmen.TabIndex = 0;
            this.pnlOgretmen.Visible = false;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(77, 247);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 6;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(135, 206);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(75, 23);
            this.btnReddet.TabIndex = 5;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(17, 206);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.AutoGenerateColumns = false;
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciDersIDDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn,
            this.onayDurumuDataGridViewCheckBoxColumn});
            this.dgvOgrenciler.DataSource = this.ogrenciDersBindingSource;
            this.dgvOgrenciler.Location = new System.Drawing.Point(3, 19);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(233, 145);
            this.dgvOgrenciler.TabIndex = 3;
            this.dgvOgrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciDersIDDataGridViewTextBoxColumn
            // 
            this.ogrenciDersIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciDersID";
            this.ogrenciDersIDDataGridViewTextBoxColumn.HeaderText = "OgrenciDersID";
            this.ogrenciDersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDersIDDataGridViewTextBoxColumn.Name = "ogrenciDersIDDataGridViewTextBoxColumn";
            this.ogrenciDersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciDersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // onayDurumuDataGridViewCheckBoxColumn
            // 
            this.onayDurumuDataGridViewCheckBoxColumn.DataPropertyName = "OnayDurumu";
            this.onayDurumuDataGridViewCheckBoxColumn.HeaderText = "OnayDurumu";
            this.onayDurumuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.onayDurumuDataGridViewCheckBoxColumn.Name = "onayDurumuDataGridViewCheckBoxColumn";
            this.onayDurumuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ogrenciDersBindingSource
            // 
            this.ogrenciDersBindingSource.DataMember = "OgrenciDers";
            this.ogrenciDersBindingSource.DataSource = this.ogrenciYonetimDataSet;
            // 
            // ogrenciYonetimDataSet
            // 
            this.ogrenciYonetimDataSet.DataSetName = "OgrenciYonetimDataSet";
            this.ogrenciYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMemur
            // 
            this.pnlMemur.Controls.Add(this.label6);
            this.pnlMemur.Controls.Add(this.txtKontenjan);
            this.pnlMemur.Controls.Add(this.label5);
            this.pnlMemur.Controls.Add(this.label4);
            this.pnlMemur.Controls.Add(this.label3);
            this.pnlMemur.Controls.Add(this.label2);
            this.pnlMemur.Controls.Add(this.label1);
            this.pnlMemur.Controls.Add(this.lblAd);
            this.pnlMemur.Controls.Add(this.txtOgrenciSoyad);
            this.pnlMemur.Controls.Add(this.lstOgrenciler);
            this.pnlMemur.Controls.Add(this.btnGunlukRapor);
            this.pnlMemur.Controls.Add(this.btnDersOgrencileriListele);
            this.pnlMemur.Controls.Add(this.btnDersGuncelleMemur);
            this.pnlMemur.Controls.Add(this.btnDersSilMemur);
            this.pnlMemur.Controls.Add(this.btnDersEkleMemur);
            this.pnlMemur.Controls.Add(this.txtHocaAdi);
            this.pnlMemur.Controls.Add(this.txtDersKredi);
            this.pnlMemur.Controls.Add(this.txtDersAdi);
            this.pnlMemur.Controls.Add(this.dataGridView1);
            this.pnlMemur.Controls.Add(this.btnOgrenciGuncelle);
            this.pnlMemur.Controls.Add(this.btnOgrenciSil);
            this.pnlMemur.Controls.Add(this.btnOgrenciEkle);
            this.pnlMemur.Controls.Add(this.txtOgrenciGNO);
            this.pnlMemur.Controls.Add(this.txtOgrenciAd);
            this.pnlMemur.Location = new System.Drawing.Point(546, 97);
            this.pnlMemur.Name = "pnlMemur";
            this.pnlMemur.Size = new System.Drawing.Size(515, 341);
            this.pnlMemur.TabIndex = 0;
            this.pnlMemur.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hoca Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ders Kredi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ders Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ortalama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Öğrenci Soyadı";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(32, 158);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(77, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Öğrenci Adı";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(143, 177);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgrenciSoyad.TabIndex = 3;
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 16;
            this.lstOgrenciler.Location = new System.Drawing.Point(299, 5);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(184, 148);
            this.lstOgrenciler.TabIndex = 14;

            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Location = new System.Drawing.Point(143, 316);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(75, 23);
            this.btnGunlukRapor.TabIndex = 13;
            this.btnGunlukRapor.Text = "Günlük Rapor";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            // 
            // btnDersOgrencileriListele
            // 
            this.btnDersOgrencileriListele.Location = new System.Drawing.Point(42, 316);
            this.btnDersOgrencileriListele.Name = "btnDersOgrencileriListele";
            this.btnDersOgrencileriListele.Size = new System.Drawing.Size(75, 23);
            this.btnDersOgrencileriListele.TabIndex = 12;
            this.btnDersOgrencileriListele.Text = "Dersin Öğrencilerini Gösterme";
            this.btnDersOgrencileriListele.UseVisualStyleBackColor = true;
            // 
            // btnDersGuncelleMemur
            // 
            this.btnDersGuncelleMemur.Location = new System.Drawing.Point(351, 306);
            this.btnDersGuncelleMemur.Name = "btnDersGuncelleMemur";
            this.btnDersGuncelleMemur.Size = new System.Drawing.Size(75, 23);
            this.btnDersGuncelleMemur.TabIndex = 11;
            this.btnDersGuncelleMemur.Text = "Ders Güncelle";
            this.btnDersGuncelleMemur.UseVisualStyleBackColor = true;
            // 
            // btnDersSilMemur
            // 
            this.btnDersSilMemur.Location = new System.Drawing.Point(396, 277);
            this.btnDersSilMemur.Name = "btnDersSilMemur";
            this.btnDersSilMemur.Size = new System.Drawing.Size(75, 23);
            this.btnDersSilMemur.TabIndex = 10;
            this.btnDersSilMemur.Text = "Ders Sil";
            this.btnDersSilMemur.UseVisualStyleBackColor = true;
            this.btnDersSilMemur.Click += new System.EventHandler(this.btnDersSilMemur_Click);
            // 
            // btnDersEkleMemur
            // 
            this.btnDersEkleMemur.Location = new System.Drawing.Point(287, 277);
            this.btnDersEkleMemur.Name = "btnDersEkleMemur";
            this.btnDersEkleMemur.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkleMemur.TabIndex = 9;
            this.btnDersEkleMemur.Text = "Ders Ekle";
            this.btnDersEkleMemur.UseVisualStyleBackColor = true;
            this.btnDersEkleMemur.Click += new System.EventHandler(this.btnDersEkleMemur_Click);
            // 
            // txtHocaAdi
            // 
            this.txtHocaAdi.Location = new System.Drawing.Point(278, 240);
            this.txtHocaAdi.Name = "txtHocaAdi";
            this.txtHocaAdi.Size = new System.Drawing.Size(100, 22);
            this.txtHocaAdi.TabIndex = 8;
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(412, 189);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(100, 22);
            this.txtDersKredi.TabIndex = 7;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(278, 189);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(100, 22);
            this.txtDersAdi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn1,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.gNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ogrenciIDDataGridViewTextBoxColumn1
            // 
            this.ogrenciIDDataGridViewTextBoxColumn1.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn1.Name = "ogrenciIDDataGridViewTextBoxColumn1";
            this.ogrenciIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // gNODataGridViewTextBoxColumn
            // 
            this.gNODataGridViewTextBoxColumn.DataPropertyName = "GNO";
            this.gNODataGridViewTextBoxColumn.HeaderText = "GNO";
            this.gNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNODataGridViewTextBoxColumn.Name = "gNODataGridViewTextBoxColumn";
            this.gNODataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.ogrenciYonetimDataSetBindingSource;
            // 
            // ogrenciYonetimDataSetBindingSource
            // 
            this.ogrenciYonetimDataSetBindingSource.DataSource = this.ogrenciYonetimDataSet;
            this.ogrenciYonetimDataSetBindingSource.Position = 0;
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(87, 288);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(124, 23);
            this.btnOgrenciGuncelle.TabIndex = 4;
            this.btnOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(148, 240);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(92, 23);
            this.btnOgrenciSil.TabIndex = 3;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(35, 240);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(97, 23);
            this.btnOgrenciEkle.TabIndex = 2;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtOgrenciGNO
            // 
            this.txtOgrenciGNO.Location = new System.Drawing.Point(82, 208);
            this.txtOgrenciGNO.Name = "txtOgrenciGNO";
            this.txtOgrenciGNO.Size = new System.Drawing.Size(100, 22);
            this.txtOgrenciGNO.TabIndex = 1;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(25, 177);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgrenciAd.TabIndex = 0;
            // 
            // ogrenciDersTableAdapter
            // 
            this.ogrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.Location = new System.Drawing.Point(412, 240);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(100, 22);
            this.txtKontenjan.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kontenjan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.pnlMemur);
            this.Controls.Add(this.pnlOgretmen);
            this.Controls.Add(this.pnlOgrenci);
            this.Controls.Add(this.btnSecimOnayla);
            this.Controls.Add(this.cmbSecim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOgrenci.ResumeLayout(false);
            this.pnlOgretmen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).EndInit();
            this.pnlMemur.ResumeLayout(false);
            this.pnlMemur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSecim;
        private System.Windows.Forms.Button btnSecimOnayla;
        private System.Windows.Forms.Panel pnlOgrenci;
        private System.Windows.Forms.Panel pnlOgretmen;
        private System.Windows.Forms.Panel pnlMemur;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.ComboBox cmbGuncelle;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private OguBs.OgrenciYonetimDataSet ogrenciYonetimDataSet;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource;
        private OguBs.OgrenciYonetimDataSetTableAdapters.OgrenciDersTableAdapter ogrenciDersTableAdapter;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onayDurumuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrenciYonetimDataSetBindingSource;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtOgrenciGNO;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private OguBs.OgrenciYonetimDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnDersOgrencileriListele;
        private System.Windows.Forms.Button btnDersGuncelleMemur;
        private System.Windows.Forms.Button btnDersSilMemur;
        private System.Windows.Forms.Button btnDersEkleMemur;
        private System.Windows.Forms.TextBox txtHocaAdi;
        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontenjan;
    }
}
