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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            Menu yeniMenu = new Menu()
            {
                MenuAdi = txtMenuAdi.Text,
                Fiyati=Convert.ToDouble(nmrMenuFiyat.Value)
            
            };
            Form2.Menuler.Add(yeniMenu);
            MessageBox.Show("Menü başarılı bir şekilde sisteme eklendi");
        }
    }
}
