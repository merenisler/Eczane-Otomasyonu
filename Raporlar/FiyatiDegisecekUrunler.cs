using EczaneOtomasyonu.Faturalar;
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

namespace EczaneOtomasyonu.Raporlar
{
    public partial class FiyatiDegisecekUrunler : Form
    {
        public FiyatiDegisecekUrunler()
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
        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
            this.Hide();
        }
        private void btnOzetTablo_Click(object sender, EventArgs e)
        {
            OzetTablo ozetTablo = new OzetTablo();
            ozetTablo.Show();
            this.Hide();
        }
        private void btnStokRaporu_Click(object sender, EventArgs e)
        {
            StokRaporu stokRaporu = new StokRaporu();
            stokRaporu.Show();
            this.Hide();
        }
        private void btnStokAnalizRaporu_Click(object sender, EventArgs e)
        {
            StokAnalizRaporu stokAnalizRaporu = new StokAnalizRaporu();
            stokAnalizRaporu.Show();
            this.Hide();
        }
        private void btnUrunGirisCikis_Click(object sender, EventArgs e)
        {
            UrunGirisCikisRaporu urunGirisCikisRaporu = new UrunGirisCikisRaporu();
            urunGirisCikisRaporu.Show();
            this.Hide();
        }
        private void btnVeresiyeRaporu_Click(object sender, EventArgs e)
        {
            VeresiyeRaporu veresiyeRaporu = new VeresiyeRaporu();
            veresiyeRaporu.Show();
            this.Hide();
        }
        private void btnKarekodKontrol_Click(object sender, EventArgs e)
        {
            KarekodKontrol karekodKontrol = new KarekodKontrol();
            karekodKontrol.Show();
        }
    }
}
