using EczaneOtomasyonu.Faturalar;
using EczaneOtomasyonu.Raporlar;
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

namespace EczaneOtomasyonu.Stok
{
    public partial class StokGir : Form
    {
        public StokGir()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";


        private void btnSatis_Click(object sender, EventArgs e)
        {
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.Show();
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
        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            StokListesi stokListesi = new StokListesi();
            stokListesi.Show();
            this.Hide();
        }
        private void btnTopluSatis_Click(object sender, EventArgs e)
        {
            TopluSatis topluSatis = new TopluSatis();
            topluSatis.Show();
            this.Hide();
        }
        private void btnZayiUrunler_Click(object sender, EventArgs e)
        {
            ZayiUrunler zayiUrunler = new ZayiUrunler();
            zayiUrunler.Show();
            this.Hide();
        }
        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            YeniUrun yeniUrun = new YeniUrun();
            yeniUrun.Show();
        }
        private void btnKopyadanEkle_Click(object sender, EventArgs e)
        {
            txtUrunAra.Text = Clipboard.GetText();
        }

        private void StokGir_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select top (" + PerakendeSatis.listenenIlacAdet + ") B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat, I.UreticiFirma as UreticiFirma from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IlacListesi.Rows.Add(dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["UreticiFirma"]);
            }
            bg.Close();
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
                    SqlCommand cmd = new SqlCommand("select B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat, I.UreticiFirma as UreticiFirma from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId where B.Barcode='" + girilenBarkod + "'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        IlacListesi.Rows.Clear();
                        IlacListesi.Rows.Add(dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["UreticiFirma"]);
                    }
                    bg.Close();
                }
                catch (Exception)
                { }
                e.Handled = true;
            }
        }

        private void IlacListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Sadece belirli bir sütunun üstüne tıklanıldığında işlem yap
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = IlacListesi.Rows[e.RowIndex];

                // Seçilen satırın verilerini al
                txtBarkod.Text = selectedRow.Cells[0].Value.ToString(); // 1. sütun
                txtUrunAdi.Text = selectedRow.Cells[1].Value.ToString(); // 2. sütun
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            string ilacAdi = txtUrunAdi.Text;
            int adet = Convert.ToInt32(txtAdet.Text);
            bg.Open();
            SqlCommand komut = new SqlCommand("update Ilaclar set StokMiktari=StokMiktari+" + adet + " where IlacAdi='" + ilacAdi + "'", bg);
            komut.ExecuteNonQuery();
            bg.Close();

            IlacListesi.Rows.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select top (" + PerakendeSatis.listenenIlacAdet + ") B.Barcode as Barcode, I.IlacAdi as IlacAdi, I.StokMiktari as StokMiktari, I.BirimFiyat as BirimFiyat, I.UreticiFirma as UreticiFirma from Ilaclar I inner join IlacBarcode B on I.IlacId=B.IlacId", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IlacListesi.Rows.Add(dr["Barcode"], dr["IlacAdi"], dr["StokMiktari"], dr["UreticiFirma"]);
            }
            bg.Close();

            txtBarkod.Text = "";
            txtUrunAdi.Text = "";
            txtAdet.Text = "";
        }
    }
}
