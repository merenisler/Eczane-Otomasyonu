using EczaneOtomasyonu.Faturalar;
using EczaneOtomasyonu.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu.Stok
{
    public partial class ZayiUrunler : Form
    {
        public ZayiUrunler()
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
        private void btnStokGir_Click(object sender, EventArgs e)
        {
            StokGir stokGir = new StokGir();
            stokGir.Show();
            this.Hide();
        }
        private void btnTopluSatis_Click(object sender, EventArgs e)
        {
            TopluSatis topluSatis = new TopluSatis();
            topluSatis.Show();
            this.Hide();
        }
    }
}
