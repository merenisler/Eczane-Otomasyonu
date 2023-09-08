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

namespace EczaneOtomasyonu.Faturalar
{
    public partial class AlisIadeFaturalari : Form
    {
        public AlisIadeFaturalari()
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
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
            this.Hide();
        }
        private void btnAlisFatura_Click(object sender, EventArgs e)
        {
            AlisIadeFaturalari alisIadeFaturalari = new AlisIadeFaturalari();
            alisIadeFaturalari.Show();
            this.Hide();
        }
        private void btnSatisFatura_Click(object sender, EventArgs e)
        {
            SatisFaturalari satisFaturalari = new SatisFaturalari();
            satisFaturalari.Show();
            this.Hide();
        }
        private void btnSatisIade_Click(object sender, EventArgs e)
        {
            SatisIadeFaturalari satisIadeFaturalari = new SatisIadeFaturalari();
            satisIadeFaturalari.Show();
            this.Hide();
        }
    }
}
