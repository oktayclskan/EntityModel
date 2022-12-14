using System;
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
            //Console.WriteLine("");
            //Console.WriteLine("                                             ***      OKİ BİSİKLET      ***");
            //Console.WriteLine("");
            //Console.WriteLine("Eklemek İstediğiniz Markayı Yazınız");
            //string marka = Console.ReadLine();

            //b.Marka = marka;

            //Console.WriteLine("Eklemek İstediğiniz Markanın Modelini Yazınız");
            //string model = Console.ReadLine();
            //b.Model = model;

            //Console.WriteLine("Bisikletin Ağırlığını Belirtiniz");
            //string agırlık = Console.ReadLine();
            //b.Agirlik = agırlık;


            //List<Kategoriler> kategoriler = dm.KategoriListele();
            //foreach (Kategoriler item in kategoriler)
            //{
            //    Console.WriteLine(item.ID + ".) " + item.KategoriTur);
            //}
            //Console.WriteLine("Kategori ID'sini Yazınız");
            //int KategoriId = Convert.ToInt32(Console.ReadLine());
            //b.KategoriID = KategoriId;

            //List<Suspansiyonlar> suspansiyonlar = dm.SuspansiyonListele();
            //foreach (Suspansiyonlar item in suspansiyonlar)
            //{
            //    Console.WriteLine($"{item.ID}.){item.Marka} {item.Model} Fiyat = {item.Fiyat}");
            //}
            //Console.WriteLine("Suspansiyon ID'sini Yazınız");
            //int suspansiyonID = Convert.ToInt32(Console.ReadLine());
            //b.SuspansiyonID = suspansiyonID;

            //List<Renkler> renkler = dm.RenkListele();
            //foreach (Renkler item in renkler)
            //{
            //    Console.WriteLine($"{item.ID}.) {item.Renk}");
            //}
            //Console.WriteLine("Renk Id Belirtiniz");
            //int renkID = Convert.ToInt32(Console.ReadLine());
            //b.RenkID = renkID;

            //List<GovdeTurleri> govdeturleri = dm.GovdeTurListele();
            //foreach (GovdeTurleri item in govdeturleri)
            //{
            //    Console.WriteLine($"{item.ID}.)  {item.Govdetur}");
            //}
            //Console.WriteLine("Lütfen Gövde Türünün ID'sini Belirtiniz");
            //int govdeTur = Convert.ToInt32(Console.ReadLine());
            //b.GovdeID = govdeTur;

            //List<VitesSecenekler> vitessecenek = dm.VitesSecenekListele();
            //foreach (VitesSecenekler item in vitessecenek)
            //{
            //    Console.WriteLine($"{item.Id}.) {item.Vites}");
            //}
            //Console.WriteLine("Lütfen Vites Id'sini Belirtiniz");
            //int vitesıd = Convert.ToInt32(Console.ReadLine());
            //b.VitesID = vitesıd;

            //Console.WriteLine("Bisikletin Fiyatını Belirtiniz");
            //decimal fiyat = Convert.ToDecimal(Console.ReadLine());
            //b.Fiyat = fiyat;

            //if (dm.BisikletEkle(b))
            //{
            //    Console.WriteLine("Bisikletiniz Eklenmiştir");
            //}
            //else
            //{
            //    Console.WriteLine("Bisiklet Eklene İşleminde Hata Oluştu");
            //}


            #endregion
            #region Veri Güncelle

            List<Bisikletler> bisikletler = dm.BisikletListele();
            foreach (Bisikletler item in bisikletler)
            {
                Console.WriteLine($"{item.ID}.) {item.Marka} {item.Model} {item.Agirlik} {item.KategoriID} {item.SuspansiyonID} {item.RenkID} {item.VitesID} {item.GovdeID} {item.Fiyat}");
            }
            


            Bisikletler u = new Bisikletler();
            Console.WriteLine("Güncellemek istediğiniz ID yazınz");
            u.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1"+".) "+ "MARKA");
            Console.WriteLine("2"+".)" + "MODEL");
            Console.WriteLine("3"+".)" + "AĞIRLIK");
            Console.WriteLine("4"+".)" + "KATEGORİ");
            Console.WriteLine("5"+".)" + "AĞIRLIK");
            Console.WriteLine("nesini güncellemek istiyorsunuz");
            string gncll = Console.ReadLine();
            
            


            if (gncll=="1")
            {
                Console.WriteLine("Güncellemek istediğiniz Markayı Yazınız");
                u.Marka = Console.ReadLine();

                if (dm.MarkaUpdateEt(u))
                {
                    Console.WriteLine("başarılı");
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }
            }
            else if (gncll=="2")
            {
                Console.WriteLine("Güncellemek istediğiniz Modeli Yazınız");
                u.Model = Console.ReadLine();
                if (dm.ModelUpdateET(u))
                {
                    Console.WriteLine("Başarılı");
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }
            }
            else if (gncll=="3")
            {
                Console.WriteLine("GÜNCEL AĞIRLIĞI YAZINIZ");
                u.Agirlik = Console.ReadLine();
                if (dm.AgırlıkUpdateEt(u))
                {
                    Console.WriteLine("Başarılı");
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }
            }
            else if (gncll=="4")
            {
                List < Kategoriler > kategoriler = dm.KategoriListele();
                foreach (Kategoriler item in kategoriler)
                {
                    Console.WriteLine(item.ID + ".) " + item.KategoriTur);
                }
                Console.WriteLine("GÜNCEL KATEGORİYİ SEÇİNİZ");
                int kate = Convert.ToInt32(Console.ReadLine());
                u.KategoriID = kate;
                if (dm.KategoriUpdateEt(u))
                {
                    Console.WriteLine("Başarılı");
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }
            }

            



            #endregion
        }
    }
}
