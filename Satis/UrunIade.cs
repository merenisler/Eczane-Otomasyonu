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
using EczaneOtomasyonu.Stok;

namespace EczaneOtomasyonu.Satis
{
    public partial class UrunIade : Form
    {
        public UrunIade()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";
        public static int hastaIdIade = 0;
        public static bool HastaIdIade = false;
        public static int satisId = 0;

        private void btnStok_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            StokListesi stokListesi = new StokListesi();
            stokListesi.Show();
            this.Hide();
        }
        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            AlisFaturalari alisFaturalari = new AlisFaturalari();
            alisFaturalari.Show();
            this.Hide();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
            this.Hide();
        }
        private void btnPerakendeSatis_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.Show();
            this.Hide();
        }
        private void btnVersiye_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            Veresiye veresiye = new Veresiye();
            veresiye.Show();
            this.Hide();
        }
        private void btnVeresiyeListesi_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            VeresiyeListesi veresiyeListesi = new VeresiyeListesi();
            veresiyeListesi.Show();
            this.Hide();
        }
        private void btnPosEkranı_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            PosEkrani posEkrani = new PosEkrani();
            posEkrani.Show();
            this.Hide();
        }
        private void btnTakasIslemleri_Click(object sender, EventArgs e)
        {
            hastaIdIade = 0;
            TakasIslemleri takasIslemleri = new TakasIslemleri();
            takasIslemleri.Show();
            this.Hide();
        }
        private void btnTumHastalar_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
        }

        private void UrunIade_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1500;
            Timer1.Enabled = true;
            Timer1.Start();
            HastaIdIade = true;
            PerakendeSatis.HastaId = false;
            VeresiyeListesi.HastaIdVeresiye = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            HastaListesi.Rows.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select S.SatisId as SatisId, M.MusteriAdi as MusteriAdi, S.Tarih as Tarih from Satislar S inner join Musteriler M on  S.OdemeDurumu='Ödendi'  and M.MusteriAdi='" + cmbBxHastaListesi.Text + "'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HastaListesi.Rows.Add(dr["SatisId"], dr["MusteriAdi"], dr["Tarih"]);
            }
            bg.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (hastaIdIade != 0)
            {
                string hastaAdi = "";
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Musteriler where MusteriId=" + hastaIdIade + "", bg);
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

        private void HastaListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SatisListesi.Rows.Clear();
            txtToplamTutar.Text = "";
            // Sadece belirli bir sütunun üstüne tıklanıldığında işlem yap
            if (e.RowIndex >= 0)
            {
                int tutar = 0;
                int toplamTutar = 0;
                DataGridViewRow selectedRow = HastaListesi.Rows[e.RowIndex];
                // Seçilen satırın verilerini al
                satisId = (int)selectedRow.Cells[0].Value; // 1. sütun

                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from ShoppingCart where SatisId='" + satisId + "'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisListesi.Rows.Add(false, dr["IlacBarkod"], dr["IlacAdi"], dr["Miktar"], dr["BirimFiyat"], dr["ToplamFiyat"]);
                    toplamTutar = toplamTutar + (int)dr["ToplamFiyat"];
                }
                txtToplamTutar.Text = toplamTutar.ToString();
                bg.Close();

                lblSatisNo.Text = "Satış No:" + satisId.ToString();
            }
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (txtToplamTutar.Text != "")
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand komut = new SqlCommand("update Satislar set OdemeDurumu=@p1 where SatisId=@p2", bg);
                komut.Parameters.AddWithValue("@p1", "İade");
                komut.Parameters.AddWithValue("@p2", satisId);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                komut = new SqlCommand("update ZRapor set OdemeYontemi=@p1 where SatisId=@p2", bg);
                komut.Parameters.AddWithValue("@p1", "İade");
                komut.Parameters.AddWithValue("@p2", satisId);
                komut.ExecuteNonQuery();
                bg.Close();

                foreach (DataGridViewRow row in SatisListesi.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string ilacAdi = row.Cells["UrunAdi"].Value.ToString();
                        int miktar = Convert.ToInt32(row.Cells["Miktar"].Value.ToString());

                        bg.Open();
                        komut = new SqlCommand("update Ilaclar set StokMiktari=StokMiktari+@p1 where IlacAdi=@p2", bg);
                        komut.Parameters.AddWithValue("@p1", miktar);
                        komut.Parameters.AddWithValue("@p2", ilacAdi);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                }

                satisId = 0;
                SatisListesi.Rows.Clear();
                txtToplamTutar.Text = "";
            }
            else
                MessageBox.Show("İlaç Seçimi Yapınız!");
        }
    }
}
