﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniIslem;


namespace EntityModelOrnekV2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataModel dm = new DataModel();
            Bisikletler b = new Bisikletler();


            #region Konsoldan alınan kategori yi ekle s

            //Console.WriteLine("Eklemek İstediğiniz Kategori Adını Yapınız");
            //string kategori = Console.ReadLine();
            //Kategoriler k = new Kategoriler();
            //k.KategoriTur =kategori ;

            //if (dm.KategoriEkle(k))
            //{
            //    Console.WriteLine("Ekleme işlemi başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Ekleme işlemi başarısız");
            //}


            #endregion
            #region Konsoldan alınan veri ile bisiklet ekle
            Console.WriteLine("Eklemek İstediğiniz Markayı Yazınız");
            string marka = Console.ReadLine();
            
            b.Marka = marka;

            Console.WriteLine("Eklemek İstediğiniz Markanın Modelini Yazınız");
            string model = Console.ReadLine();
            b.Model = model;

            Console.WriteLine("Bisikletin Ağırlığını Belirtiniz");
            int agırlık = Convert.ToInt32(Console.ReadLine());
            b.Agırlık = agırlık;


            List<Kategoriler> kategoriler = dm.KategoriListele();
            foreach (Kategoriler item in kategoriler)
            {
                Console.WriteLine(item.ID + ".) " + item.KategoriTur);
            }
            Console.WriteLine("Kategori ID'sini Yazınız");
            int KategoriId = Convert.ToInt32(Console.ReadLine());
            b.KategoriID = KategoriId;

            List<Suspansiyonlar> suspansiyonlar = dm.SuspansiyonListele();
            foreach (Suspansiyonlar item in suspansiyonlar)
            {
                Console.WriteLine($"{item.ID}.){item.Marka} {item.Model} Fiyat = {item.Fiyat}");
            }
            Console.WriteLine("Suspansiyon ID'sini Yazınız");
            int suspansiyonID = Convert.ToInt32(Console.ReadLine());
            b.SuspansiyonID = suspansiyonID;

            List<Renkler> renkler = dm.RenkListele();
            foreach (Renkler item in renkler)
            {
                Console.WriteLine($"{item.ID}.) {item.Renk}");
            }
            Console.WriteLine("Renk Id Belirtiniz");



            #endregion
        }
    }
}
