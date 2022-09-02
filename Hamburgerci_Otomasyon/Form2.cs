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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<Menu> Menuler = new List<Menu>() 
        { 
            new Menu() { MenuAdi = "Bigmac", Fiyati = 76 }, 
            new Menu() { MenuAdi = "2liTavukMenu", Fiyati = 45 }, 
            new Menu() { MenuAdi = "CheeseBurger", Fiyati = 50 }, 
            new Menu() { MenuAdi = "KofteBurger", Fiyati = 88 }, 
            new Menu() { MenuAdi = "SteakHouse", Fiyati = 150 }
        };
        public static List<EkstraMalzeme> EkstraMalzemes = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme() {EkstraAdi = "Ranch", Fiyati=2.5},
            new EkstraMalzeme() {EkstraAdi = "Ketçap", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Mayonez", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Barbekü", Fiyati=3.5},
            new EkstraMalzeme() {EkstraAdi = "Buffalo", Fiyati=3.5}
        };
        public static List<Siparis> mevcutSiparisleri = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }
            foreach (var item in EkstraMalzemes)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }
            foreach (var item in mevcutSiparisleri)
            {
                listBox1.Items.Add(item);
            }
            TutarHesaplama();
            rdbKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;
        }
        private double TutarHesaplama()
        {
            double toplamTutar = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)listBox1.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SecilenMenu = (Menu)cmbMenuler.SelectedItem;
            if (rdbKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            else
                yeniSiparis.Boyut = Boyut.Buyuk;
            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {yeniSiparis.EkstraMalzemes.Add((EkstraMalzeme)item.Tag);

                }
            }
            yeniSiparis.Adet = Convert.ToInt32(nupAdet.Value);
            yeniSiparis.Hesapla();

            mevcutSiparisleri.Add(yeniSiparis);
            tumSiparisler.Add(yeniSiparis);
            listBox1.Items.Add(yeniSiparis);
            TutarHesaplama();
            //Temizleme metodunu çağır

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı : "+ TutarHesaplama().ToString() + "\n Satın Almayı tamamlamak ister misin?","Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                mevcutSiparisleri.Clear();
                TutarHesaplama(); // 0 açekiyorum kırmızı olarak yazdığım toplam tutar : 0 ı
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("siparişiniz iptal edildi!");
            }
        }
    }
}
