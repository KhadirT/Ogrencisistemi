using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.ogrenciYonetimDataSet.Ogrenci);
            this.ogrenciDersTableAdapter.Fill(this.ogrenciYonetimDataSet.OgrenciDers);
            LoadDersler(); 
            LoadOgrenciler();
            pnlOgretmen.Visible = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Veritabanı bağlantısı başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }
        string connectionString = "Server=.;Database=OgrenciYonetim;Trusted_Connection=True;";

        // Öğrenci verilerini DataGridView'e yükle
        private void LoadOgrenciBilgileri()
        {
            string query = @"
                SELECT o.OgrenciID, o.Ad,o.Soyad, o.GNO, 
                       STRING_AGG(d.DersAdi, ', ') AS Dersler, 
                       SUM(d.DersKredisi) AS ToplamKredi
                FROM Ogrenci o
                JOIN OgrenciDers od ON o.OgrenciID = od.OgrenciID
                JOIN Ders d ON od.DersID = d.DersID
                GROUP BY o.OgrenciID, o.Ad,o.Soyad, o.GNO";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOgrenciler.DataSource = dt; // DataGridView'e veri bağla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata: " + ex.Message);
            }
        }

        // Veritabanından öğrenci bilgilerini yükler
        private void LoadOgrenciler()
        {
            // Öğrenci bilgilerini listelemek için SQL sorgusu
            string query = "SELECT OgrenciID, Ad, Soyad, GNO FROM Ogrenci";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Listeyi temizle
                    lstOgrenciler.Items.Clear();

                    // Verileri doldur
                    while (reader.Read())
                    {
                        // Öğrenci bilgilerini al ve listeye ekle
                        string ogrenciID = reader["OgrenciID"].ToString();
                        string ad = reader["Ad"].ToString();
                        string soyad = reader["Soyad"].ToString();
                        string gno = reader["GNO"].ToString();

                        // ListViewItem oluştur ve ekle
                        ListViewItem item = new ListViewItem(ogrenciID);
                        item.SubItems.Add(ad);
                        item.SubItems.Add(soyad);
                        item.SubItems.Add(gno);
                        lstOgrenciler.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenciler yüklenirken hata: " + ex.Message);
            }
        }

        // Dersleri veritabanından çekme ve ComboBox'a ekleme
        private void LoadDersler()
        {
            // SQL Server bağlantı dizesi (veritabanınızın bağlantı bilgilerini burada girin)
            string connectionString = "Server=.;Database=OgrenciYonetim;Trusted_Connection=True;";

            //Ders Listeleme
            string query = "SELECT DersAdi, DersKredisi FROM Ders";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbDersler.Items.Clear();
                    cmbGuncelle.Items.Clear();

                    // Her bir satırı ComboBox'a ekliyoruz
                    while (reader.Read())
                    {
                        // Ders adı ve kredi bilgisi
                        string dersAdı = reader["DersAdi"].ToString();
                        string dersKredi = reader["DersKredisi"].ToString();

                        // ComboBox'a ekleme
                        cmbDersler.Items.Add($"{dersAdı} ({dersKredi})");
                        cmbGuncelle.Items.Add($"{dersAdı} ({dersKredi})");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        // Öğrenci panelinde Ders Ekleme işlemi
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (cmbDersler.SelectedItem != null)
            {
                lstDersler.Items.Add(cmbDersler.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen bir ders seçin.");
            }
        }

        // Öğrenci panelinde Ders Silme işlemi
        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItem != null)
            {
                lstDersler.Items.Remove(lstDersler.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
            }
        }

        // Öğrenci panelinde Ders Güncelleme işlemi
        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItem != null && cmbGuncelle.SelectedItem != null)
            {
                int index = lstDersler.SelectedIndex;
                lstDersler.Items[index] = cmbGuncelle.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir ders seçin ve ardından yeni dersi seçin.");
            }
        }

        // Seçim butonuna tıklanınca ilgili paneli göstermek için
        private void btnSecimOnayla_Click(object sender, EventArgs e)
        {
            // Seçilen değeri kontrol ediyoruz
            string secim = cmbSecim.SelectedItem.ToString();

            // İlk olarak tüm panelleri gizliyoruz
            pnlOgrenci.Visible = false;
            pnlOgretmen.Visible = false;
            pnlMemur.Visible = false;

            // Seçilen seçimle ilgili paneli görünür yapıyoruz
            if (secim == "Öğrenci")
            {
                pnlOgrenci.Visible = true;
            }
            else if (secim == "Öğretmen")
            {
                pnlOgretmen.Visible = true;
            }
            else if (secim == "Öğrenci İşleri")
            {
                pnlMemur.Visible = true;
            }
        }

        private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT DersID, DersAdi + '(' + CAST(DersKredisi AS VARCHAR) + ')' AS DersBilgisi FROM Ders";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDersler.Items.Add(new
                        {
                            DersID = reader["DersID"],
                            DersBilgisi = reader["DersBilgisi"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dersler yüklenirken hata: " + ex.Message);
            }
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count > 0)
            {
                int ogrenciID = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells["OgrenciID"].Value);
                int toplamKredi = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells["ToplamKredi"].Value);
                double gno = Convert.ToDouble(dgvOgrenciler.SelectedRows[0].Cells["GNO"].Value);

                // Kredi sınırı kontrolü
                int krediSiniri = gno >= 3.00 ? 25 : 21;
                if (toplamKredi > krediSiniri)
                {
                    MessageBox.Show($"Öğrencinin toplam kredisi kredi sınırını aşıyor (Maks: {krediSiniri}). Onaylanamaz.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE OgrenciDers SET OnayDurumu = 1 WHERE OgrenciID = @OgrenciID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ders seçimleri onaylandı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Onay sırasında hata: " + ex.Message);
                }

                // Verileri yenile
                LoadOgrenciBilgileri();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count > 0)
            {
                int ogrenciID = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells["OgrenciID"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM OgrenciDers WHERE OgrenciID = @OgrenciID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ders seçimleri reddedildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reddetme sırasında hata: " + ex.Message);
                }

                // Verileri yenile
                LoadOgrenciBilgileri();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.");
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadOgrenciBilgileri();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ad = txtOgrenciAd.Text;
            string soyad = txtOgrenciSoyad.Text;
            string gno = txtOgrenciGNO.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(gno))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.");
                return;
            }

            string query = "INSERT INTO Ogrenci (Ad, Soyad, GNO) VALUES (@ad, @soyad, @gno)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@gno", gno);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci başarıyla eklendi.");
                LoadOgrenciler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken hata: " + ex.Message);
            }
        }

        // Öğrenci siler
        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedItems == null || lstOgrenciler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin.");
                return;
            }

            string ogrenciID = ((ListViewItem)lstOgrenciler.SelectedItems[0]).SubItems[0].Text;

            if (string.IsNullOrEmpty(ogrenciID))
            {
                MessageBox.Show("Seçilen öğrencinin ID'si alınamadı.");
                return;
            }

            string query = "DELETE FROM Ogrenci WHERE OgrenciID = @ogrenciID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci başarıyla silindi.");
                LoadOgrenciler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci silinirken hata: " + ex.Message);
            }
        }

        // Yeni ders ekler
        private void btnDersEkleMemur_Click(object sender, EventArgs e)
        {
            string dersKodu = Guid.NewGuid().ToString().Substring(0, 8);
            string dersAdi = txtDersAdi.Text;
            int kredi;
            string query = "INSERT INTO Dersler (DersKodu, DersAdi, HocaAdi, Kontenjan) VALUES (@DersKodu, @DersAdi, @HocaAdi, @Kontenjan)";
/*            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DersKodu", dersKodu); // Ders kodu oluşturulmalı
            command.Parameters.AddWithValue("@DersAdi", dersAdi);
            command.Parameters.AddWithValue("@HocaAdi", txtHocaAdi);
            command.Parameters.AddWithValue("@Kontenjan", txtKontenjan);
*/
            if (string.IsNullOrWhiteSpace(dersAdi) || !int.TryParse(txtDersKredi.Text, out kredi))
            {
                MessageBox.Show("Lütfen geçerli bir ders adı ve kredi girin.");
                return;
            }

            string query1 = "INSERT INTO Ders (DersAdi, DersKredisi) VALUES (@dersAdi, @kredi)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dersAdi", dersAdi);
                    cmd.Parameters.AddWithValue("@kredi", kredi);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ders başarıyla eklendi.");
                LoadDersler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders eklenirken hata: " + ex.Message);
            }
        }

        private void btnDersSilMemur_Click(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
                return;
            }

            string dersID = ((ListViewItem)lstOgrenciler.SelectedItems[0]).SubItems[0].Text;
            string query = "DELETE FROM Ders WHERE DersID = @dersID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dersID", dersID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ders başarıyla silindi.");
                LoadDersler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders silinirken hata: " + ex.Message);
            }
        }

        // Öğrenci günceller
        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçin.");
                return;
            }

            string ogrenciID = ((ListViewItem)lstOgrenciler.SelectedItems[0]).SubItems[0].Text;
            string yeniAd = txtOgrenciAd.Text;
            string yeniSoyad = txtOgrenciSoyad.Text;
            string yeniGNO = txtOgrenciGNO.Text;

            if (string.IsNullOrWhiteSpace(yeniAd) || string.IsNullOrWhiteSpace(yeniSoyad) || string.IsNullOrWhiteSpace(yeniGNO))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.");
                return;
            }

            string query = "UPDATE Ogrenci SET Ad = @ad, Soyad = @soyad, GNO = @gno WHERE OgrenciID = @ogrenciID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ad", yeniAd);
                    cmd.Parameters.AddWithValue("@soyad", yeniSoyad);
                    cmd.Parameters.AddWithValue("@gno", yeniGNO);
                    cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                LoadOgrenciler(); // Öğrenci listelerini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci güncellenirken hata: " + ex.Message);
            }
        }
    }
}