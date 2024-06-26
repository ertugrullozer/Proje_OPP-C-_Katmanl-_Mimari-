﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using Proje_OPP_C__Katmanlı_Mimari_.Ornekler;

namespace Proje_OPP_C__Katmanlı_Mimari_.Controllers
{
    public class DefaultController1 : Controller
    {

        //void İslemeler()
        //{
        
        //    Class1 c = new Class1();
        //    c.Topla();
        //}
        void mesajlar() 
        {

            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "merhaba proje denemeleri";
            ViewBag.m3 = "selamlar hi hello bonjour";
        }
        //Geriye değer döndüren metotlar

        int topla()
        {
            int s1 = 20;
            int s2 = 20;
            int sonuc =s1 + s2;
            return sonuc;
        }

        int cevre() 
        {
            int kısa = 10;
            int uzun= 20;
            int c = 2 * (kısa + uzun);
            return c;
        }
        int Faktöriyel() 
        {
            int f= 1;
            int sayi = 5;
            for(int i = sayi; i > 1; i--) 
            {
                f = f * i;

            }
            return f;
            
        }

        //string metotlar
        string cumle() 
        {
            string c = "küçük hanımlar küçük beyler sizler hepiniz geleceğin birer gülü,parlayan," +
                "ışık saçan yıldızı olacaksınız.";
            return c;
        }
        public IActionResult Musteriler() 
        {

            ViewBag.d = cumle();
            return View();
        }

        //paremetre kullanımı string
        void mesajListesi(string p)
        {
            ViewBag.mesage = p;
        }
        //paremetre kullanımı int
        int topla(int s1,int s2)
        {
            int t=s1 + s2;
            return t;
        }

        public IActionResult Index() 
        { 
            mesajlar();
            mesajListesi("Parametre İsmi");
            ViewBag.tp = topla(5, 5);
            return View();
        }

        public IActionResult Urunler() 
        {
            mesajlar(); 
            ViewBag.t=topla();
            ViewBag.c=cevre();
            ViewBag.F=Faktöriyel();

            return View();
        }
        public IActionResult Deneme() 
        { 
            Sehirler sehirler = new Sehirler();
            sehirler.SehirId = 1;
            sehirler.SehirAd = "İstanbul";
            sehirler.Nufus = 1600000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Mavi";
            ViewBag.v1 = sehirler.SehirId;
            ViewBag.v2 = sehirler.SehirAd;
            ViewBag.v3 = sehirler.Nufus;
            ViewBag.z4 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;

            sehirler.SehirId = 2;
            sehirler.SehirAd = "Üsküp";
            sehirler.Nufus = 1600000;
            sehirler.Ulke = "Makedonya";
            sehirler.Renk1 = "Sarı";
            ViewBag.z1 = sehirler.SehirId;
            ViewBag.z2 = sehirler.SehirAd;
            ViewBag.z3 = sehirler.Nufus;
            ViewBag.z4 = sehirler.Ulke;
            ViewBag.z5 = sehirler.Renk1;
            return View();
        }

       

    }
}
