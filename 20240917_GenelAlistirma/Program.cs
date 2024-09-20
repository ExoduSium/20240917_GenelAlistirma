// ÖĞRENCİ KAYIT OTOMASYONU
// ------------------------
// 1- Öğrenci Ekle
// 2- Öğrencileri Listele
// 3- Öğrenci Sil
// 4- Öğrencilerin Genel Not Ortalaması
// 5- Öğrencilerin Genel Yaş Ortalaması
// 6- Toplam Öğrenci Sayısı
// 0- Çıkış

using _20240917_GenelAlistirma;





ConsoleKey cevap;
do
{
    Console.Clear();
    Console.WriteLine("ÖĞRENCİ KAYIT OTOMASYONU");
    Console.WriteLine("------------------------");
    Console.WriteLine("1- Öğrenci Ekle");
    Console.WriteLine("2- Öğrencileri Listele");
    Console.WriteLine("3- Öğrenci Sil");
    Console.WriteLine("4- Öğrencilerin Genel Not Ortalaması");
    Console.WriteLine("5- Öğrencilerin Genel Yaş Ortalaması");
    Console.WriteLine("6- Toplam Öğrenci Sayısı");
    Console.WriteLine("0- Çıkış");
    Console.Write("Hangi işlemi yapmak istersiniz? ");
    cevap = Console.ReadKey().Key;
    Menu.Islemler(cevap);
} while (cevap != ConsoleKey.NumPad0 && cevap != ConsoleKey.D0);

Console.Clear();
Console.WriteLine("Programı Kullandığınız için Teşekkür Ederiz");
Console.WriteLine("Kapatmak için Bir Tuşa Basınız");