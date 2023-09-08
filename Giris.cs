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

namespace EczaneOtomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string personel = "";
            int personelId = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Personel where PersonelAdi=@p1 and PersonelSifre=@p2", bg);
            cmd.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bg.Close();
            bool sifreKontrol = false;
            if (dt.Rows.Count > 0)
            {
                sifreKontrol = true;
                personel = txtPersonelAdi.Text;
            }
            else
                sifreKontrol = false;

            bg.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Personel where PersonelAdi='" + txtPersonelAdi.Text + "' and PersonelSifre='" + txtSifre.Text + "'", bg);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                personelId = (int)dr2["personelId"];
            }
            bg.Close();
            if (sifreKontrol == true)
            {
                try
                {
                    string Saat = DateTime.Now.ToLongTimeString();
                    string Tarih = DateTime.Now.ToShortDateString();
                    char ayrac = '.';
                    string[] Tarih1 = Tarih.Split(ayrac);
                    string yıl = Tarih1[2];
                    string ay = Tarih1[1];
                    string gun = Tarih1[0];
                    string tarihİlk = yıl + "-" + ay + "-" + gun;

                    bg.Open();
                    string kayit = "update Personel set SonGirisTarih=@p1, SonGirisSaat=@p2 where PersonelId=" + personelId + "";
                    SqlCommand komut = new SqlCommand(kayit, bg);
                    komut.Parameters.AddWithValue("@p1", tarihİlk);
                    komut.Parameters.AddWithValue("@p2", Saat);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                PerakendeSatis perakendeSatis = new PerakendeSatis();
                perakendeSatis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                txtPersonelAdi.Text = "";
                txtSifre.Text = "";
            }
        }
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string personel = "";
                int personelId = 0;
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Personel where PersonelAdi=@p1 and PersonelSifre=@p2", bg);
                cmd.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                bg.Close();
                bool sifreKontrol = false;
                if (dt.Rows.Count > 0)
                {
                    sifreKontrol = true;
                    personel = txtPersonelAdi.Text;
                }
                else
                    sifreKontrol = false;

                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select * from Personel where PersonelAdi='" + txtPersonelAdi.Text + "' and PersonelSifre='" + txtSifre.Text + "'", bg);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    personelId = (int)dr2["personelId"];
                }
                bg.Close();
                if (sifreKontrol == true)
                {
                    try
                    {
                        string Saat = DateTime.Now.ToLongTimeString();
                        string Tarih = DateTime.Now.ToShortDateString();
                        char ayrac = '.';
                        string[] Tarih1 = Tarih.Split(ayrac);
                        string yıl = Tarih1[2];
                        string ay = Tarih1[1];
                        string gun = Tarih1[0];
                        string tarihİlk = yıl + "-" + ay + "-" + gun;

                        bg.Open();
                        string kayit = "update Personel set SonGirisTarih=@p1, SonGirisSaat=@p2 where PersonelId=" + personelId + "";
                        SqlCommand komut = new SqlCommand(kayit, bg);
                        komut.Parameters.AddWithValue("@p1", tarihİlk);
                        komut.Parameters.AddWithValue("@p2", Saat);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                    PerakendeSatis perakendeSatis = new PerakendeSatis();
                    perakendeSatis.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                    txtPersonelAdi.Text = "";
                    txtSifre.Text = "";
                }
            }
        }
    }
}
