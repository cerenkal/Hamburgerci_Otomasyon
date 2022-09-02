using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci_Otomasyon
{
   public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemes = new List<EkstraMalzeme>();
        }
        public Menu SecilenMenu { get; set; } // comboboxtan çektiği için 1 tane alabiliyor. Menüden.
        public List<EkstraMalzeme> EkstraMalzemes { get; set; }
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }
        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.Fiyati;
            //küçük ise hiçbişey yapma orta ise 0,10 ile çarp büyük ise 0,30
            switch (Boyut)
            {
               
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar + 0.10;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.30;
                    break;
               
            }
            foreach (var ekstra in EkstraMalzemes)
            {
                ToplamTutar += ekstra.Fiyati;
            }
            ToplamTutar = ToplamTutar * Adet;
        }

        //listbox a seçilen siparişi ekrana düzgün formatta yazmak için ToString metodu override edip metot gövdesi değistirilmiştir. Artık aşağıda vermiş olduğumuz gibi yazacaktır.
        public override string ToString()
        {
            if (EkstraMalzemes.Count<1)
            {
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy: {Boyut}, ToplamTutar : {ToplamTutar}";
            }
            else
            {
                string ekstaMalzemeler = null;
                foreach (EkstraMalzeme ekstra in EkstraMalzemes)
                {
                    ekstaMalzemeler += ekstra.EkstraAdi + ","; //ketçap,ranch,mayonez
                }
                ekstaMalzemeler = ekstaMalzemeler.Trim(','); // en son eklenen virgülü siler
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy: {Boyut}, ToplamTutar : {ToplamTutar}, Ekstra : {ekstaMalzemeler}";
            }
        }

    }
}
