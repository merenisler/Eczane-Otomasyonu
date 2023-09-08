using EczaneOtomasyonu.Faturalar;
using EczaneOtomasyonu.Raporlar;
using EczaneOtomasyonu.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu.Satis
{
    public partial class Veresiye : Form
    {
        public Veresiye()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";


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
        private void btnVeresiyeListesi_Click(object sender, EventArgs e)
        {
            VeresiyeListesi veresiyeListesi = new VeresiyeListesi();
            veresiyeListesi.Show();
            this.Hide();
        }
        private void btnPosEkrani_Click(object sender, EventArgs e)
        {
            PosEkrani posEkrani = new PosEkrani();
            posEkrani.Show();
            this.Hide();
        }
        private void btnTakasIslemleri_Click(object sender, EventArgs e)
        {
            TakasIslemleri takasIslemleri = new TakasIslemleri();
            takasIslemleri.Show();
            this.Hide();
        }
    }
}
