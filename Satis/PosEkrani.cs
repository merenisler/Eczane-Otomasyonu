using EczaneOtomasyonu.Faturalar;
using EczaneOtomasyonu.Raporlar;
using EczaneOtomasyonu.Stok;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyonu.Satis
{
    public partial class PosEkrani : Form
    {
        public PosEkrani()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";
        List<int> faturaNo = new List<int>();
        public static string odemeYontemi = "";
        public static int odemeAlinacakId = 0;


        private void btnStok_Click(object sender, EventArgs e)
        {
            StokListesi stokListesi = new StokListesi();
            stokListesi.Show();
            this.Hide();
        }
        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            AlisFaturalari alisFaturalari = new AlisFaturalari();
            alisFaturalari.Show();
            this.Hide();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
            this.Hide();
        }
        private void btnPerakendeSatis_Click(object sender, EventArgs e)
        {
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.Show();
            this.Hide();
        }
        private void btnUrunIade_Click(object sender, EventArgs e)
        {
            UrunIade urunIade = new UrunIade();
            urunIade.Show();
            this.Hide();
        }
        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            Veresiye veresiye = new Veresiye();
            veresiye.Show();
            this.Hide();
        }
        private void btnVeresiyeListesi_Click(object sender, EventArgs e)
        {
            VeresiyeListesi veresiyeListesi = new VeresiyeListesi();
            veresiyeListesi.Show();
            this.Hide();
        }
        private void btnTakasIslemleri_Click(object sender, EventArgs e)
        {
            TakasIslemleri takasIslemleri = new TakasIslemleri();
            takasIslemleri.Show();
            this.Hide();
        }

        public void dinamikMetodSatislar(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            SatisListesi.Rows.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from ShoppingCart where SatisId=" + (sender as System.Windows.Forms.Button).TabIndex + "", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SatisListesi.Rows.Add(dr["IlacAdi"], dr["Miktar"], dr["BirimFiyat"], dr["ToplamFiyat"]);
            }
            bg.Close();

            HastaListesi.Rows.Clear();
            bg.Open();
            cmd = new SqlCommand("select M.MusteriAdi as MusteriAdi, M.Telefon as Telefon, S.Tarih as Tarih, S.ToplamFiyat as ToplamFiyat from Musteriler M inner join Satislar S on M.MusteriId=S.MusteriId where SatisId=" + ((sender as System.Windows.Forms.Button).TabIndex) + "", bg);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tarih = "";
                DateTime sonTrh = DateTime.Now;
                if (sonTrh.ToString().Length == 19)
                    tarih = (dr["Tarih"].ToString().Remove(10, 9));
                if (sonTrh.ToString().Length == 18)
                    tarih = (dr["Tarih"].ToString().Remove(9, 9));
                HastaListesi.Rows.Add(dr["MusteriAdi"], "Reçete", dr["Telefon"], tarih);
                txtNakit.Text = dr["ToplamFiyat"].ToString();
            }
            bg.Close();
            odemeAlinacakId = (sender as System.Windows.Forms.Button).TabIndex;
            odemeYontemi = "Nakit";
            txtFisNo.Text = (sender as System.Windows.Forms.Button).TabIndex.ToString();
        }

        private void PosEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as urunAdet from Satislar where OdemeDurumu='Bekliyor'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet = (int)dr["urunAdet"]; }
            bg.Close();

            int satisId = 0;
            List<string> musteriAdi = new List<string>();
            List<int> toplamFiyat = new List<int>();
            List<string> tarih = new List<string>();
            for (int i = 1; i <= urunAdet; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY SatisId) indexer, * from Satislar where OdemeDurumu='Bekliyor') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { satisId = ((int)dr["SatisId"]); }
                bg.Close();
                bg.Open();
                cmd = new SqlCommand("Select S.SatisId as SatisId, M.MusteriAdi as MusteriAdi, S.ToplamFiyat as ToplamFiyat, S.Tarih as Tarih From Satislar S inner join Musteriler M on S.MusteriId=M.MusteriId where SatisId=" + satisId + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    faturaNo.Add((int)dr["SatisId"]);
                    musteriAdi.Add((string)dr["MusteriAdi"]);
                    toplamFiyat.Add((int)dr["ToplamFiyat"]);
                    DateTime tarih2 = (DateTime)dr["Tarih"];
                    if (tarih2.ToString().Length == 19)
                        tarih.Add(tarih2.ToString().Remove(10, 9));
                    if (tarih2.ToString().Length == 18)
                        tarih.Add(tarih2.ToString().Remove(9, 9));
                }
                bg.Close();
            }
            for (int i = 0; i < urunAdet; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "Buton" + i.ToString();
                btn.Size = new Size(415, 140);
                try { btn.Text = ("Fatura No:" + faturaNo[(i)] + "\n" + "Müşteri Adi: " + musteriAdi[(i)] + "\n" + "Fiyat: " + toplamFiyat[(i)] + "\n" + "Tarih: " + tarih[(i)]); }
                catch (Exception) { }
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 14, FontStyle.Bold);
                btn.BackColor = Color.Firebrick;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                panelSatislar.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetodSatislar);
                btn.TabIndex = faturaNo[(i)];
            }
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            int nakit = 0;
            int veresiye = 0;
            if (txtNakit.Text != "")
            {
                nakit = Convert.ToInt32(txtNakit.Text);
                txtNakit.Text = "";
                txtKrediKarti.Text = nakit.ToString();
            }
            if (txtVeresiye.Text != "")
            {
                veresiye = Convert.ToInt32(txtVeresiye.Text);
                txtVeresiye.Text = "";
                txtKrediKarti.Text = veresiye.ToString();
            }
            odemeYontemi = "Kredi Kartı";
        }

        private void btnVeresiye_Click_1(object sender, EventArgs e)
        {
            int nakit = 0;
            int kredi = 0;
            if (txtNakit.Text != "")
            {
                nakit = Convert.ToInt32(txtNakit.Text);
                txtNakit.Text = "";
                txtVeresiye.Text = nakit.ToString();
            }
            if (txtKrediKarti.Text != "")
            {
                kredi = Convert.ToInt32(txtKrediKarti.Text);
                txtKrediKarti.Text = "";
                txtVeresiye.Text = kredi.ToString();
            }
            odemeYontemi = "Veresiye";
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            int kredi = 0;
            int veresiye = 0;
            if (txtVeresiye.Text != "")
            {
                veresiye = Convert.ToInt32(txtVeresiye.Text);
                txtVeresiye.Text = "";
                txtNakit.Text = veresiye.ToString();
            }
            if (txtKrediKarti.Text != "")
            {
                kredi = Convert.ToInt32(txtKrediKarti.Text);
                txtKrediKarti.Text = "";
                txtNakit.Text = kredi.ToString();
            }
            odemeYontemi = "Nakit";
        }

        private void txtKrediKarti_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse veya boşluk ise, işlemi engelle
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                int nakit = 0;
                int kredi = 0;
                int veresiye = 0;
                if (txtNakit.Text != "")
                {
                    nakit = Convert.ToInt32(txtNakit.Text);
                    kredi = Convert.ToInt32(txtKrediKarti.Text);
                    nakit = nakit - kredi;
                    txtNakit.Text = nakit.ToString();
                }
                if (txtVeresiye.Text != "")
                {
                    veresiye = Convert.ToInt32(txtVeresiye.Text);
                    kredi = Convert.ToInt32(txtKrediKarti.Text);
                    veresiye = veresiye - kredi;
                    txtVeresiye.Text = veresiye.ToString();
                }
                e.Handled = true;
            }
        }

        private void txtVeresiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse veya boşluk ise, işlemi engelle
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                int nakit = 0;
                int kredi = 0;
                int veresiye = 0;
                if (txtNakit.Text != "")
                {
                    nakit = Convert.ToInt32(txtNakit.Text);
                    veresiye = Convert.ToInt32(txtVeresiye.Text);
                    nakit = nakit - veresiye;
                    txtNakit.Text = nakit.ToString();
                }
                if (txtKrediKarti.Text != "")
                {
                    kredi = Convert.ToInt32(txtKrediKarti.Text);
                    veresiye = Convert.ToInt32(txtVeresiye.Text);
                    kredi = kredi - veresiye;
                    txtKrediKarti.Text = kredi.ToString();
                }
                e.Handled = true;
            }
        }

        private void txtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse veya boşluk ise, işlemi engelle
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                int nakit = 0;
                int kredi = 0;
                int veresiye = 0;
                if (txtKrediKarti.Text != "")
                {
                    kredi = Convert.ToInt32(txtKrediKarti.Text);
                    nakit = Convert.ToInt32(txtNakit.Text);
                    kredi = kredi - nakit;
                    txtKrediKarti.Text = kredi.ToString();
                }
                if (txtVeresiye.Text != "")
                {
                    veresiye = Convert.ToInt32(txtVeresiye.Text);
                    nakit = Convert.ToInt32(txtNakit.Text);
                    veresiye = veresiye - nakit;
                    txtVeresiye.Text = veresiye.ToString();
                }
                e.Handled = true;
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (odemeAlinacakId != 0)
            {
                int toplamFiyat = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Satislar where SatisId=" + odemeAlinacakId + "", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    toplamFiyat = (int)dr["ToplamFiyat"];
                }
                bg.Close();

                int nakit = 0; int krediKarti = 0; int veresiye = 0;

                if (txtNakit.Text != "")
                    nakit = Convert.ToInt32(txtNakit.Text);
                if (txtKrediKarti.Text != "")
                    krediKarti = Convert.ToInt32(txtKrediKarti.Text);
                if (txtVeresiye.Text != "")
                    veresiye = Convert.ToInt32(txtVeresiye.Text);

                int txtToplam = nakit + krediKarti + veresiye;

                if (toplamFiyat == txtToplam)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("update Satislar set OdemeDurumu=@p1 where SatisId=@p2", bg);
                    komut.Parameters.AddWithValue("@p1", "Ödendi");
                    komut.Parameters.AddWithValue("@p2", odemeAlinacakId);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    string tarih = "";
                    // Bugünkü tarihi al
                    DateTime bugunkuTarih = DateTime.Now;
                    // Bugünkü tarihi görüntüle
                    tarih = bugunkuTarih.ToString("dd/MM/yyyy");
                    char ayrac = '.';
                    string[] Tarih = tarih.Split(ayrac);
                    string yıl = Tarih[2];
                    string ay = Tarih[1];
                    string gun = Tarih[0];
                    string bugunTarih = yıl + "-" + ay + "-" + gun;

                    int adet = 0;
                    int miktar = 0;

                    bg.Open();
                    cmd = new SqlCommand("select * from ShoppingCart where SatisId=" + odemeAlinacakId + "", bg);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        adet = (int)dr["Miktar"];
                        miktar = miktar + adet;
                    }
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("insert into ZRapor(SatisId, Tarih, Miktar, ToplamFiyat, OdemeYontemi) values (@p1, @p2, @p3, @p4, @p5)", bg);
                    komut.Parameters.AddWithValue("@p1", odemeAlinacakId);
                    komut.Parameters.AddWithValue("@p2", bugunTarih);
                    komut.Parameters.AddWithValue("@p3", miktar);
                    komut.Parameters.AddWithValue("@p4", toplamFiyat);
                    komut.Parameters.AddWithValue("@p5", odemeYontemi);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    txtFisNo.Text = "";
                    txtNakit.Text = "";
                    txtKrediKarti.Text = "";
                    txtVeresiye.Text = "";
                    odemeAlinacakId = 0;
                    HastaListesi.Rows.Clear();
                    SatisListesi.Rows.Clear();
                }
            }
        }

        private void btnFisİptal_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (odemeAlinacakId != 0)
            {
                int toplamFiyat = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Satislar where SatisId=" + odemeAlinacakId + "", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    toplamFiyat = (int)dr["ToplamFiyat"];
                }
                bg.Close();

                int nakit = 0; int krediKarti = 0; int veresiye = 0;

                if (txtNakit.Text != "")
                    nakit = Convert.ToInt32(txtNakit.Text);
                if (txtKrediKarti.Text != "")
                    krediKarti = Convert.ToInt32(txtKrediKarti.Text);
                if (txtVeresiye.Text != "")
                    veresiye = Convert.ToInt32(txtVeresiye.Text);

                int txtToplam = nakit + krediKarti + veresiye;

                if (toplamFiyat == txtToplam)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("update Satislar set OdemeDurumu=@p1 where SatisId=@p2", bg);
                    komut.Parameters.AddWithValue("@p1", "İptal Edildi");
                    komut.Parameters.AddWithValue("@p2", odemeAlinacakId);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    string tarih = "";
                    // Bugünkü tarihi al
                    DateTime bugunkuTarih = DateTime.Now;
                    // Bugünkü tarihi görüntüle
                    tarih = bugunkuTarih.ToString("dd/MM/yyyy");
                    char ayrac = '.';
                    string[] Tarih = tarih.Split(ayrac);
                    string yıl = Tarih[2];
                    string ay = Tarih[1];
                    string gun = Tarih[0];
                    string bugunTarih = yıl + "-" + ay + "-" + gun;

                    int adet = 0;
                    int miktar = 0;

                    bg.Open();
                    cmd = new SqlCommand("select * from ShoppingCart where SatisId=" + odemeAlinacakId + "", bg);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        adet = (int)dr["Miktar"];
                        miktar = miktar + adet;
                    }
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("insert into ZRapor(SatisId, Tarih, Miktar, ToplamFiyat, OdemeYontemi) values (@p1, @p2, @p3, @p4, @p5)", bg);
                    komut.Parameters.AddWithValue("@p1", odemeAlinacakId);
                    komut.Parameters.AddWithValue("@p2", bugunTarih);
                    komut.Parameters.AddWithValue("@p3", miktar);
                    komut.Parameters.AddWithValue("@p4", toplamFiyat);
                    komut.Parameters.AddWithValue("@p5", "İptal Edildi");
                    komut.ExecuteNonQuery();
                    bg.Close();

                    txtFisNo.Text = "";
                    txtNakit.Text = "";
                    txtKrediKarti.Text = "";
                    txtVeresiye.Text = "";
                    odemeAlinacakId = 0;
                }
            }
        }


        private void btnYenile_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            panelSatislar.Controls.Clear();
            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as urunAdet from Satislar where OdemeDurumu='Bekliyor'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet = (int)dr["urunAdet"]; }
            bg.Close();

            int satisId = 0;
            List<string> musteriAdi = new List<string>();
            List<int> toplamFiyat = new List<int>();
            List<string> tarih = new List<string>();
            for (int i = 1; i <= urunAdet; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY SatisId) indexer, * from Satislar where OdemeDurumu='Bekliyor') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { satisId = ((int)dr["SatisId"]); }
                bg.Close();
                bg.Open();
                cmd = new SqlCommand("Select S.SatisId as SatisId, M.MusteriAdi as MusteriAdi, S.ToplamFiyat as ToplamFiyat, S.Tarih as Tarih From Satislar S inner join Musteriler M on S.MusteriId=M.MusteriId where SatisId=" + satisId + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    faturaNo.Add((int)dr["SatisId"]);
                    musteriAdi.Add((string)dr["MusteriAdi"]);
                    toplamFiyat.Add((int)dr["ToplamFiyat"]);
                    DateTime tarih2 = (DateTime)dr["Tarih"];
                    if (tarih2.ToString().Length == 19)
                        tarih.Add(tarih2.ToString().Remove(10, 9));
                    if (tarih2.ToString().Length == 18)
                        tarih.Add(tarih2.ToString().Remove(9, 9));
                }
                bg.Close();
            }
            for (int i = 0; i < urunAdet; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "Buton" + i.ToString();
                btn.Size = new Size(415, 140);
                try { btn.Text = ("Fatura No:" + faturaNo[(i)] + "\n" + "Müşteri Adi: " + musteriAdi[(i)] + "\n" + "Fiyat: " + toplamFiyat[(i)] + "\n" + "Tarih: " + tarih[(i)]); }
                catch (Exception) { }
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 14, FontStyle.Bold);
                btn.BackColor = Color.Firebrick;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                panelSatislar.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetodSatislar);
                btn.TabIndex = faturaNo[(i)];
            }
            odemeAlinacakId = 0;
        }

        private void txtFisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int SatisId = 0;
                SatisId = Convert.ToInt32(txtFisNo.Text);
                SqlConnection bg = new SqlConnection(ConnectionString);

                SatisListesi.Rows.Clear();
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from ShoppingCart where SatisId=" + SatisId + "", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisListesi.Rows.Add(dr["IlacAdi"], dr["Miktar"], dr["BirimFiyat"], dr["ToplamFiyat"]);
                }
                bg.Close();

                HastaListesi.Rows.Clear();
                bg.Open();
                cmd = new SqlCommand("select M.MusteriAdi as MusteriAdi, M.Telefon as Telefon, S.Tarih as Tarih, S.ToplamFiyat as ToplamFiyat from Musteriler M inner join Satislar S on M.MusteriId=S.MusteriId where SatisId=" + SatisId + "", bg);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string tarih = "";
                    DateTime sonTrh = DateTime.Now;
                    if (sonTrh.ToString().Length == 19)
                        tarih = (dr["Tarih"].ToString().Remove(10, 9));
                    if (sonTrh.ToString().Length == 18)
                        tarih = (dr["Tarih"].ToString().Remove(9, 9));
                    HastaListesi.Rows.Add(dr["MusteriAdi"], "Reçete", dr["Telefon"], tarih);
                    txtNakit.Text = dr["ToplamFiyat"].ToString();
                }
                bg.Close();

                odemeYontemi = "Nakit";
                e.Handled = true;
            }
        }

    }
}
