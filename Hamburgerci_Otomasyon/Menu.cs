using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci_Otomasyon
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public double Fiyati { get; set; }
        //ToString metodumu ezdiğim için artık bana nesnemi oluşturup ekrana bastığım zaman HamburgerciOdevi.Menu gibi bir ifade çıkarmayacaktır
        public override string ToString()
        {
            return $"Menü : {MenuAdi}, Fiyat : {Fiyati}";
        }
    }
}
