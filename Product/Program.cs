using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunIsmi = "Polo Yaka T-Shirt";
            urun1.Fiyat = 299;
            urun1.IndirimliFiyat = 234.99;

            Urun urun2 = new Urun();
            urun2.UrunIsmi = "Hummel Ayakkabi";
            urun2.Fiyat = 250;
            urun2.IndirimliFiyat = 180.99;

            Urun urun3 = new Urun();
            urun3.UrunIsmi = "Kol Saati";
            urun3.Fiyat = 100;
            urun3.IndirimliFiyat = 88.09;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunIsmi + ": "+ urun.Fiyat + " " +"Indirimli fiyat: " + urun.IndirimliFiyat);
            }

            Console.ReadKey();

        }
    }
    class Urun
    {
        public string UrunIsmi { get; set; }
        public double IndirimliFiyat { get; set; }
        public int Fiyat { get; set; }
    }
}
