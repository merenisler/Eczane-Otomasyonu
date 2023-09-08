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
    public partial class KarekodKontrol : Form
    {
        public KarekodKontrol()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=Eczane;Integrated Security=True";


        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
