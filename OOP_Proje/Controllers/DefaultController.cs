using Microsoft.AspNetCore.Mvc;
using OOP_Proje.Ornekler;

namespace OOP_Proje.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        //{
        //    Class1 t = new Class1();
        //    t.Topla();

        //    Class1 c = new Class1();
        //    c.Carp();
        //}

        int Topla()
        {
            int s1 = 20;
            int s2 = 20;
            return s1 + s2;
        }

        int Topla(int s1, int s2)
        {

            return s1 + s2;
        }

        int Faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }

        void Mesajlar()
        {
            ViewBag.m1 = "Bu bir Core Projesi";
            ViewBag.m2 = "Proje iyi duruyor";
            ViewBag.m3 = "Merhaba";
        }

        int Cevre()
        {
            int kKenar = 10;
            int uKenar = 20;
            return 2 * (kKenar + uKenar);
        }

        string Cumle()
        {
            string cm = "Harabat ehlini hor görme";
            return cm;

        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void Kullanici(string kullaniciAdi)
        {
            ViewBag.kAdi = kullaniciAdi;
        }
        public IActionResult Index()
        {
            Mesajlar();
            MesajListesi(Cumle());
            Kullanici("Şükrü Kaya");
            ViewBag.tp = Topla(5, 6);
            return View();
        }

        public IActionResult Urunler()
        {

            Mesajlar();
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            Kullanici("Betül");
            ViewBag.faktoriyel = Faktoriyel(7);
            return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.cm = Cumle();
            Kullanici("Bilge");
            return View();
        }

        public IActionResult Sehirler()
        {

            Sehirler sehirler = new Sehirler();
            Bayrak bayrak = new Bayrak();

            sehirler.SehirAdi = "bursa";
            sehirler.Nufus = 100000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Kırmızı";

            ViewBag.sa = sehirler.SehirAdi;
            ViewBag.sn = sehirler.Nufus;
            ViewBag.su = sehirler.Ulke;
            ViewBag.sr1 = sehirler.Renk1;
            ViewBag.sr2 = sehirler.Renk2;


            sehirler.SehirAdi = "Üsküp";
            sehirler.Nufus = 10000;
            sehirler.Ulke = "Makedonya";
            sehirler.Renk1 = "Kahverengi";
            sehirler.Renk2 = "Beyaz";

            ViewBag.saa = sehirler.SehirAdi;
            ViewBag.snn = sehirler.Nufus;
            ViewBag.suu = sehirler.Ulke;
            ViewBag.sr11 = sehirler.Renk1;
            ViewBag.sr22 = sehirler.Renk2;
            return View();
        }
    }
}
