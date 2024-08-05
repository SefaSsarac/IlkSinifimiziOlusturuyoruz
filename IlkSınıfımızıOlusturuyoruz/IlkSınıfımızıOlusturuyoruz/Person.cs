using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    public class Person
    {
        // Properties
        public string ad;
        public string soyad;
        public DateTime dogumTarihi;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public DateTime DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                dogumTarihi = value;
            }
        }
        public void BilgileriYazdır()     // Display method
        {
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Soyad: {soyad}");
            Console.WriteLine($"Doğum tarihi: {dogumTarihi.ToShortDateString()}");
            Console.WriteLine();
        }
    }
}
