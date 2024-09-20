using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240917_GenelAlistirma
{
    #region Any() Metodu
    // Koleksiyonlarda, koleksiyon adını yazdıktan sonra .Any() metodu çağırdığımız zaman bu metod bize koleksiyon içerisinde değer olup olmadığı bilgisini verir.
    //Metod, geriye bool tipinde değer döndürür. Koleksiyon içerisinde eleman var ise true yok ise false değer döndürür.
    #endregion
    internal class Menu
    {
        static List<Ogrenci> ogrenciler = new();
        public static void Islemler(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Ekle("ÖĞRENCİ EKLE");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Listele("ÖĞRENCİ LİSTESİ");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Sil("ÖĞRENCİ SİL");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    NotOrtalama("ÖĞRENCİLERİN GENEL NOT ORTALAMASI");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    YasOrtalama("ÖĞRENCİLERİN GENEL YAŞ ORTALAMASI");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    BaslikYazdir("TOPLAM ÖĞRENCİ SAYISI");
                    AnaMenuyeDon(string.Format("Litede Toplam {0} Öğrenci Kayıtlıdır", ogrenciler.Count));
                    break;

            }
        }

        private static void YasOrtalama(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                double yasToplam = 0;
                foreach (var ogr in ogrenciler)
                {
                    yasToplam += ogr.Yas;
                }
                yasToplam=yasToplam/ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} Öğrencinin Yaş Ortalaması {1}", ogrenciler.Count, Math.Round(yasToplam, 2)));

            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunmamaktadır...");
            }
        }

        private static void NotOrtalama(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                double notToplam = 0;
                foreach (var ogr in ogrenciler)
                {
                    notToplam += ogr.Ortalama;
                }
                notToplam = notToplam/ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} Öğrencinin Not Ortalaması {1}", ogrenciler.Count, Math.Round(notToplam, 2)));
            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunmamaktadır...");
            }
        }

        private static void Sil(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                Console.WriteLine();
                int index = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz\nSilme işlemini iptal etmek için 0'a basınız: ",0,ogrenciler.Count);
                if (index == 0)
                {
                    AnaMenuyeDon("Silme İşlemi İptal Edildi");
                }
                else
                {
                    int siraNo = index - 1;
                    Console.Write("{0} öğrencisini silmek istediğinize emin misiniz?(e):", ogrenciler[siraNo].TamAd);
                    if (Console.ReadKey().Key == ConsoleKey.E)
                    {
                        Console.WriteLine();
                        string silinen = ogrenciler[siraNo].TamAd;
                        ogrenciler.RemoveAt(siraNo);
                        AnaMenuyeDon(string.Format("{0} Öğrencisi Başarı İle Silindi", silinen));
                    }
                    else
                    {
                        Console.WriteLine();
                        AnaMenuyeDon("Silme İşlemi İptal Edildi");
                    }
                }
            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunmamaktadır...");
            }
        }

        private static void Listele(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                AnaMenuyeDon(string.Format("Toplam {0} Öğrenci Listelenmiştir", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunmaktadır...");
            }
            
        }

        private static void Ekle(string v)
        {
            BaslikYazdir(v);
            Ogrenci o = new();
            o.Ad = Metodlar.GetString("Öğrenci Adı: ", 2, 20);
            o.Soyad = Metodlar.GetString("Öğrenci Soyadı: ", 2, 20);
            o.N1 = Metodlar.GetDouble("1. Not: ", 0, 100);
            o.N2 = Metodlar.GetDouble("2. Not: ", 0,100);
            o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi: ", 1990,2006);
            ogrenciler.Add(o);
            AnaMenuyeDon(string.Format("{0} Öğrencisi Listeye Başarı İle Eklendi, Mevcut Öğrenci Sayısı: {1}", o.TamAd, ogrenciler.Count));
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine(v);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
            Console.ReadKey();
        }

        private static void BaslikYazdir(string v)
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }
    }
}
