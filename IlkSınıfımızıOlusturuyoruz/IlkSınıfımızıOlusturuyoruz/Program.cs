using System;

namespace Sınıf
{
    public class Program
    {
        static void Main()
        {
            // Creating student objects
            Person ogrenci1 = new Person();
            ogrenci1.Ad = "Ali";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.DogumTarihi = new DateTime(1994, 5, 10);
            Person ogrenci2 = new Person();
            ogrenci2.Ad = "Ayse";
            ogrenci2.Soyad = "Kara";
            ogrenci2.DogumTarihi = new DateTime(1998, 6, 11);

            // Creating teacher objects
            Person ogretmen1 = new Person();
            ogretmen1.Ad = "Mehmet";
            ogretmen1.Soyad = "Öztürk";
            ogretmen1.DogumTarihi = new DateTime(1978, 4, 1);
            Person ogretmen2 = new Person();
            ogretmen2.Ad = "Yeliz";
            ogretmen2.Soyad = "Işık";
            ogretmen2.DogumTarihi = new DateTime(1984, 2, 14);

            // Information is display
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci1.BilgileriYazdır();
            ogrenci2.BilgileriYazdır();

            Console.WriteLine("Öğretmen Bilgileri:");
            ogretmen1.BilgileriYazdır();
            ogretmen2.BilgileriYazdır();
        }
    }
}
