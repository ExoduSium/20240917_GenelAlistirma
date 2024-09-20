using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240917_GenelAlistirma
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double N1 { get; set; }
        public double N2 { get; set; }
        public string TamAd
        {
            get { return Ad + " " + Soyad; }
        }
        public double Ortalama
        {
            get { return (N1 + N2) / 2; }
        }
        public int Yas
        {
            get {return DateTime.Now.Year - DogumTarihi.Year; }
        }
        public void Yazdir(int sira)
        {
            Console.WriteLine("{0}- {1}", sira, TamAd);
        }
    }
}
