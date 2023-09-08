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
using EczaneOtomasyonu.Faturalar;
using EczaneOtomasyonu.Raporlar;
using EczaneOtomasyonu.Satis;
using EczaneOtomasyonu.Stok;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace EczaneOtomasyonu
{
    public partial class PerakendeSatis : Form
    {
        public PerakendeSatis()
        {
            InitializeComponent();
            InitializeDataGridView();
            //this.WindowState = FormWindowState.Maximized;
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";
        public static int listenenIlacAdet = 2500;
        public DataTable dataTable = new DataTable();
        public static int hastaId = 0;
        public static bool HastaId = false;


        private void btnStok_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            StokListesi stokListesi = new StokListesi();
            stokListesi.Show();
            this.Hide();
        }
        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            AlisFaturalari alisFaturalari = new AlisFaturalari();
            alisFaturalari.Show();
            this.Hide();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
            this.Hide();
        }
        private void btnUrunIade_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            UrunIade urunIade = new UrunIade();
            urunIade.Show();
            this.Hide();
        }
        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            Veresiye veresiye = new Veresiye();
            veresiye.Show();
            this.Hide();
        }
        private void btnVeresiyeListesi_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            VeresiyeListesi veresiyeListesi = new VeresiyeListesi();
            veresiyeListesi.Show();
            this.Hide();
        }
        private void btnPosEkrani_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            PosEkrani posEkrani = new PosEkrani();
            posEkrani.Show();
            this.Hide();
        }
        private void btnTakasIslemleri_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            TakasIslemleri takasIslemleri = new TakasIslemleri();
            takasIslemleri.Show();
            this.Hide();
        }
        private void btnKopyadanEkle_Click(object sender, EventArgs e)
        {
            txtUrunAra.Text = Clipboard.GetText();
        }
        private void btnTumHastalar_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
        }
        private void InitializeDataGridView()
        {
            IlacListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PerakendeSatis_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1500;
            Timer1.Enabled = true;
            Timer1.Start();
            HastaId = true;
            UrunIade.HastaIdIade = false;
            VeresiyeListesi.HastaIdVeresiye = false;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select top (" + listenenIlacAdet + ") B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IlacListesi.Rows.Add(false, dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["BirimFiyat"]);
            }
            bg.Close();

            IlacListesi.Columns["UrunBarkod"].ReadOnly = true;
            IlacListesi.Columns["UrunAdi"].ReadOnly = true;
            IlacListesi.Columns["StokAdet"].ReadOnly = true;
            IlacListesi.Columns["Fiyat"].ReadOnly = true;

            SatisListesi.Columns["UrunBarkod2"].ReadOnly = true;
            SatisListesi.Columns["UrunAdi2"].ReadOnly = true;
            SatisListesi.Columns["BirimFiyat"].ReadOnly = true;
            SatisListesi.Columns["ToplamFiyat"].ReadOnly = true;
        }

        private void txtUrunAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string girilenBarkod = txtUrunAra.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                try
                {
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId where B.Barcode='" + girilenBarkod + "'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        IlacListesi.Rows.Clear();
                        IlacListesi.Rows.Add(false, dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["BirimFiyat"]);
                    }
                    bg.Close();
                }
                catch (Exception)
                { }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            IlacListesi.Rows.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select top (" + listenenIlacAdet + ") B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IlacListesi.Rows.Add(false, dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["BirimFiyat"]);
            }
            bg.Close();
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in IlacListesi.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Seç"] as DataGridViewCheckBoxCell;

                // CheckBox seçiliyse, satýrý dataGridView2'ye ekle
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    SatisListesi.Rows.Add(false, row.Cells[1].Value, row.Cells[2].Value, "1", row.Cells[4].Value, row.Cells[4].Value);
                    if (txtToplamTutar.Text == "")
                        txtToplamTutar.Text = ((int)row.Cells[4].Value).ToString();
                    else
                    {
                        int tutar = Convert.ToInt32(txtToplamTutar.Text);
                        int tutar2 = (int)row.Cells[4].Value;
                        int toplamTutar = tutar + tutar2;
                        txtToplamTutar.Text = toplamTutar.ToString();
                    }
                    row.Cells[0].Value = false;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SatisListesi.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Seç2"] as DataGridViewCheckBoxCell;
                // CheckBox seçiliyse, satýrý dataGridView2'ye ekle
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    int sayi = checkBoxCell.RowIndex;
                    int toplamUcret = (int)row.Cells[5].Value;
                    int toplamTutar = Convert.ToInt32(txtToplamTutar.Text);
                    toplamTutar = toplamTutar - toplamUcret;
                    DataGridViewRow selectedRow = SatisListesi.Rows[sayi];
                    // Satýrý DataGridView'den kaldýr
                    SatisListesi.Rows.Remove(selectedRow);
                    txtToplamTutar.Text = toplamTutar.ToString();

                }
            }
        }

        private void SatisListesi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            // Sadece miktar sütununda deðiþiklik olduðunda iþlem yap
            if (e.ColumnIndex == Miktar.Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = SatisListesi.Rows[e.RowIndex];
                DataGridViewCell miktarCell = row.Cells[Miktar.Index];
                DataGridViewCell fiyatCell = row.Cells[BirimFiyat.Index];
                DataGridViewCell toplamFiyatCell = row.Cells[ToplamFiyat.Index];
                DataGridViewCell urunAdiCell = row.Cells[UrunAdi.Index];

                // Miktar ve fiyat hücrelerini kontrol et
                if (miktarCell.Value != null && fiyatCell.Value != null)
                {
                    int miktar = Convert.ToInt32(miktarCell.Value);
                    decimal fiyat = Convert.ToDecimal(fiyatCell.Value);
                    decimal fiyat2 = Convert.ToDecimal(toplamFiyatCell.Value);
                    string ilacAdi = (string)urunAdiCell.Value;

                    decimal ilacFiyat = 0;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from Ilaclar where IlacAdi='" + ilacAdi + "'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ilacFiyat = (int)dr["BirimFiyat"];
                    }
                    bg.Close();

                    decimal yeniFiyat = 0;
                    yeniFiyat = ilacFiyat * miktar;

                    // Fiyat hücresini güncelle
                    toplamFiyatCell.Value = yeniFiyat;

                    if (txtToplamTutar.Text != "")
                    {
                        decimal tutar = Convert.ToDecimal(txtToplamTutar.Text);
                        tutar = tutar - fiyat2;
                        decimal toplamTutar = tutar + yeniFiyat;
                        txtToplamTutar.Text = toplamTutar.ToString();
                    }
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string tarih = "";
            // Bugünkü tarihi al
            DateTime bugunkuTarih = DateTime.Now;
            // Bugünkü tarihi görüntüle
            tarih = bugunkuTarih.ToString("dd/MM/yyyy");
            char ayrac = '.';
            string[] Tarih = tarih.Split(ayrac);
            string yýl = Tarih[2];
            string ay = Tarih[1];
            string gun = Tarih[0];
            string bugunTarih = yýl + "-" + ay + "-" + gun;

            int toplamFiyat = 0;
            int satisAdet = 0;
            if (txtToplamTutar.Text != "")
            {
                if (cmbBxHastaListesi.Text != "")
                {
                    toplamFiyat = Convert.ToInt32(txtToplamTutar.Text);

                    SqlConnection bg = new SqlConnection(ConnectionString);
                    bg.Open();
                    SqlCommand komut = new SqlCommand("insert into Satislar(Tarih, MusteriId, ToplamFiyat, OdemeDurumu) values (@p1, @p2, @p3, @p4)", bg);
                    komut.Parameters.AddWithValue("@p1", bugunTarih);
                    komut.Parameters.AddWithValue("@p2", hastaId);
                    komut.Parameters.AddWithValue("@p3", toplamFiyat);
                    komut.Parameters.AddWithValue("@p4", "Bekliyor");
                    komut.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) as satisAdet from Satislar", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        satisAdet = (int)dr["satisAdet"];
                    }
                    bg.Close();

                    foreach (DataGridViewRow row in SatisListesi.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string ilacBarkod = row.Cells["UrunBarkod2"].Value.ToString();
                            string ilacAdi = row.Cells["UrunAdi2"].Value.ToString();
                            int miktar = Convert.ToInt32(row.Cells["Miktar"].Value.ToString());
                            int ilacFiyat = Convert.ToInt32(row.Cells["BirimFiyat"].Value.ToString());
                            int ilacToplamFiyat = Convert.ToInt32(row.Cells["ToplamFiyat"].Value.ToString());
                            bg.Open();
                            komut = new SqlCommand("insert into ShoppingCart(SatisId, Tarih, IlacBarkod, IlacAdi, Miktar, BirimFiyat, ToplamFiyat) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bg);
                            komut.Parameters.AddWithValue("@p1", satisAdet);
                            komut.Parameters.AddWithValue("@p2", bugunTarih);
                            komut.Parameters.AddWithValue("@p3", ilacBarkod);
                            komut.Parameters.AddWithValue("@p4", ilacAdi);
                            komut.Parameters.AddWithValue("@p5", miktar);
                            komut.Parameters.AddWithValue("@p6", ilacFiyat);
                            komut.Parameters.AddWithValue("@p7", ilacToplamFiyat);
                            komut.ExecuteNonQuery();
                            bg.Close();

                            bg.Open();
                            komut = new SqlCommand("update Ilaclar set StokMiktari=StokMiktari-@p1 where IlacAdi=@p2", bg);
                            komut.Parameters.AddWithValue("@p1", miktar);
                            komut.Parameters.AddWithValue("@p2", ilacAdi);
                            komut.ExecuteNonQuery();
                            bg.Close();
                        }
                    }


                    hastaId = 0;
                    SatisListesi.Rows.Clear();
                    lblBarkod.Text = "";
                    lblIlacAdi.Text = "";
                    lblBirimFiyat.Text = "";
                    lblUreticiFirma.Text = "";
                    txtToplamTutar.Text = "";
                    btnResim.ImageList = null;
                }
                else
                    MessageBox.Show("Hasta Seçimi Yapýnýz!");
            }
            else
                MessageBox.Show("Ýlaç Seçimi Yapýnýz!");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            hastaId = 0;
            SatisListesi.Rows.Clear();
            lblBarkod.Text = "";
            lblIlacAdi.Text = "";
            lblBirimFiyat.Text = "";
            lblUreticiFirma.Text = "";
            txtToplamTutar.Text = "";
            btnResim.ImageList = null;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (hastaId != 0)
            {
                string hastaAdi = "";
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Musteriler where MusteriId=" + hastaId + "", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hastaAdi = (string)dr["MusteriAdi"];
                }
                bg.Close();
                cmbBxHastaListesi.Text = hastaAdi;
            }
            else
                cmbBxHastaListesi.Text = "";
        }

        private void IlacListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Sadece belirli bir sütunun üstüne týklanýldýðýnda iþlem yap
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = IlacListesi.Rows[e.RowIndex];

                // Seçilen satýrýn verilerini al
                lblBarkod.Text = selectedRow.Cells[1].Value.ToString(); // 1. sütun
                lblIlacAdi.Text = selectedRow.Cells[2].Value.ToString(); // 2. sütun
                lblBirimFiyat.Text = selectedRow.Cells[4].Value.ToString(); // 2. sütun

                string ureticiFirma = "";
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Ilaclar where IlacAdi='" + selectedRow.Cells[2].Value.ToString() + "'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ureticiFirma = (string)dr["UreticiFirma"];
                }
                bg.Close();
                lblUreticiFirma.Text = ureticiFirma;

                btnResim.ImageList = ýmageList6;
                btnResim.ImageIndex = 0;
            }
        }

    }
}