using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci_Otomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            EkstraMalzeme yeniEkstraMalzeme = new EkstraMalzeme()
            {
                EkstraAdi = txtEkstraMalzemeAdi.Text,
                Fiyati = Convert.ToDouble(nmrEkstraMalzemeFiyat.Value)

            };
            Form2.EkstraMalzemes.Add(yeniEkstraMalzeme);
            MessageBox.Show("Ekstra Malzeme başarılı bir şekilde sisteme eklendi");
        }
    }
}
