using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _20240917_GenelAlistirma
{
    internal class Metodlar
    {
        #region string.IsNullOrEmpty
        // string.IsNullOrEmpty() metodu, içerisine parametre olarak girilen string değerin boş olup olmadığını kontrol eder. Geriye bool tipinde değer döndürür. string değer boş ise true, boş değil ise false değer döndürür.
        #endregion

        
        // Öğrenci isimlerini isterken çağıracağımız metod, GetString metodudur.
        public static string GetString(string metin, int min=1, int max=500)
        {
            string txt = string.Empty;
            bool hata = false;
            do
            {
                Console.Write(metin);// "Öğrenci Adı: "
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Değer boş bırakılamaz");
                    hata = true;
                }
                else
                {
                    if (txt.Length < min || txt.Length > max)
                    {
                        Console.WriteLine("Lütfen min.{0}, max.{1} karakter giriniz",min,max);
                        hata = true;
                    }
                    else if (!IsOnlyLetter(txt.Replace(" ","")))
                    {
                        Console.WriteLine("Lütfen Sadece Harf Değeri Giriniz");
                        hata = true;
                    }
                    else
                    {
                        hata = false;
                    }
                }
            } while (hata);
            return txt;
        }

        // Karakterleri sırasıyla kontrol edip girilen değerlerin gerçekten harf olup olmadığını kontrol eden metod.
        private static bool IsOnlyLetter(string txt)
        {
            foreach (var character in txt)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }

        // Silmek istediğimiz öğrencinin sıra numarasını kullanıcıdan isterken kullanacağımız metod.
        public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin); // Not bilgisi giriniz: 
                try
                {
                    sayi = int.Parse(Console.ReadLine());// 95
                    if (sayi >= min && sayi <= max)// 
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0}, max.{1} aralığında değer giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata bir değer girdiniz...");
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        // Kullanıcıdan öğrenci not bilgisi talep ederken kullanacağımız metod.
        public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0}, max.{1} aralığında sayı giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        // Kullanıcıdan öğrencinin doğum tarihi bilgisini isterken kullanacağımız metod.

        public static DateTime GetDateTime(string metin, int minYear, int maxYear)
        {
            DateTime date = DateTime.Now;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    if (date.Year >= minYear && date.Year <= maxYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0}, max.{1} yılları arasında bir değer giriniz",minYear,maxYear);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata =true;
                }
            } while (hata);
            return date;
        }
    }
}
