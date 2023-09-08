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
    public partial class YeniUrun : Form
    {
        public YeniUrun()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";


        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtUrunAdi.Text = "";
            txtAdet.Text = "";
            txtBirimFiyat.Text = "";
            txtUreticiFirma.Text = "";
            txtSonKullanmaTarihi.Text = "";
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtBarkod.Text != "" && txtUrunAdi.Text != "" && txtAdet.Text != "" && txtBirimFiyat.Text != "" && txtUreticiFirma.Text != "" && txtSonKullanmaTarihi.Text != "")
            {
                Guid urunAdi = new Guid(txtUrunAdi.Text);
                Guid barkod = new Guid(txtBarkod.Text);
                int adet = Convert.ToInt32(txtAdet.Text);
                string ureticiFirma = txtUreticiFirma.Text.ToString();
                int birimFiyat = Convert.ToInt32(txtBirimFiyat.Text);
                string sonKullanmaTarihi = txtSonKullanmaTarihi.Text.ToString();

                bool ilacKayitliMi = false;

                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from IlacBarcode", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    Guid barcode;
                    barcode = (Guid)oku["Barcode"];
                    if (barcode == barkod)
                        ilacKayitliMi = true;
                }
                bg.Close();

                if (ilacKayitliMi == false)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("insert into Ilaclar(IlacAdi, StokMiktari, BirimFiyat, SonKullanmaTarihi, UreticiFirma) values (@p1, @p2, @p3, @p4, @p5)", bg);
                    komut.Parameters.AddWithValue("@p1", urunAdi);
                    komut.Parameters.AddWithValue("@p2", adet);
                    komut.Parameters.AddWithValue("@p3", birimFiyat);
                    komut.Parameters.AddWithValue("@p4", sonKullanmaTarihi);
                    komut.Parameters.AddWithValue("@p4", ureticiFirma);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    int IlacToplamAdet = 0;
                    bg.Open();
                    cmd = new SqlCommand("select count(*) as IlacToplamAdet from Ilaclar", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        IlacToplamAdet = (int)oku["IlacToplamAdet"];
                    }
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("insert into IlacBarcode(IlacId, Barcode) values (@p1, @p2)", bg);
                    komut.Parameters.AddWithValue("@p1", IlacToplamAdet);
                    komut.Parameters.AddWithValue("@p2", barkod);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }
                else
                    MessageBox.Show("Girdiğiniz Barkoda Ait Ürün Bulunmakta. Kayıt Yapılamadı!");
            }
            else
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
        }
    }
}
