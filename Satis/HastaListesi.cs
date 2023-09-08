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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EczaneOtomasyonu.Satis
{
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";
        public static string adSoyad = "";


        private void HastaListesi_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["MusteriAdi"].ToString());
                listele.SubItems.Add(oku["Telefon"].ToString());
                listele.SubItems.Add(oku["Eposta"].ToString());
                listele.SubItems.Add(oku["Adres"].ToString());
                lstViewHastalar.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnHastaAra_Click(object sender, EventArgs e)
        {
            string searchCharacter = txtMusteriAra.Text; // Aranacak harf
            int adColumnIndex = 0; // 'AD' sütununun indeksi

            // ListView'deki satırları dolaşarak arama yap
            foreach (ListViewItem item in lstViewHastalar.Items)
            {
                string adValue = item.SubItems[adColumnIndex].Text;
                if (adValue.Contains(searchCharacter, StringComparison.OrdinalIgnoreCase))
                {
                    // 'AD' sütununda 'a' harfi bulunan satırı seçili hale getir
                    item.Selected = true;
                    item.EnsureVisible(); // Görüntülenen alana getir

                    // ListView'daki tüm öğeleri kaldır
                    lstViewHastalar.Items.Clear();

                    // Silinmemesi gereken satırı geri ekleyin
                    lstViewHastalar.Items.Add(item);
                }
                else
                {
                    item.Selected = false; // Aranan harfi içermiyorsa seçili değil yap
                }
            }
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            string adSoyad = "", telefon = "", eposta = "", adres = "";

            if (txtAdSoyad.Text != "")
                adSoyad = txtAdSoyad.Text;
            if (txtTelefon.Text != "")
                telefon = txtTelefon.Text;
            if (txtEposta.Text != "")
                eposta = txtEposta.Text;
            if (txtAdres.Text != "")
                adres = txtAdres.Text;

            if (adSoyad != "")
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand komut = new SqlCommand("insert into Musteriler(MusteriAdi, Telefon, Eposta, Adres) values (@p1, @p2, @p3, @p4)", bg);
                komut.Parameters.AddWithValue("@p1", adSoyad);
                komut.Parameters.AddWithValue("@p2", telefon);
                komut.Parameters.AddWithValue("@p3", eposta);
                komut.Parameters.AddWithValue("@p4", adres);
                komut.ExecuteNonQuery();
                bg.Close();

                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                txtEposta.Text = "";
                txtAdres.Text = "";
                lstViewHastalar.Items.Clear();

                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Musteriler", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem listele = new ListViewItem();
                    listele.Text = (oku["MusteriAdi"].ToString());
                    listele.SubItems.Add(oku["Telefon"].ToString());
                    listele.SubItems.Add(oku["Eposta"].ToString());
                    listele.SubItems.Add(oku["Adres"].ToString());
                    lstViewHastalar.Items.Add(listele);
                }
                bg.Close();
            }
            else
                MessageBox.Show("Hasta Adı Girilmeden Ekleme Yapamazsınız!");
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar);

            if (txtTelefon.Text.Length >= 11)
            {
                e.Handled = true;
                e.Handled = char.IsDigit(e.KeyChar);
            }
            else
                e.Handled = false;
        }

        private void lstViewHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewHastalar.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    items = lstViewHastalar.SelectedItems[0].SubItems[i].Text.ToString();
                    if (i == 0)
                        adSoyad = items;
                }
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler where MusteriAdi='" + adSoyad + "'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (PerakendeSatis.HastaId == true)
                    PerakendeSatis.hastaId = (int)oku["MusteriId"];
                if (UrunIade.HastaIdIade == true)
                    UrunIade.hastaIdIade = (int)oku["MusteriId"];
                if (VeresiyeListesi.HastaIdVeresiye == true)
                    VeresiyeListesi.hastaIdVeresiye = (int)oku["MusteriId"];
            }
            bg.Close();

            MessageBox.Show("Hasta Seçildi.");

            this.Hide();
        }

        private void txtMusteriAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMusteriAra.Text == "")
            {
                lstViewHastalar.Items.Clear();
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Musteriler", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem listele = new ListViewItem();
                    listele.Text = (oku["MusteriAdi"].ToString());
                    listele.SubItems.Add(oku["Telefon"].ToString());
                    listele.SubItems.Add(oku["Eposta"].ToString());
                    listele.SubItems.Add(oku["Adres"].ToString());
                    lstViewHastalar.Items.Add(listele);
                }
                bg.Close();
            }

        }
    }
}
