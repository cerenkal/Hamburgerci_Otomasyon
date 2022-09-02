using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci_Otomasyon
{
    public class Fonksiyonlar
    {
        
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            
            foreach (var item in koleksiyon)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }
    }
}
