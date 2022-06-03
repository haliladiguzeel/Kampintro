using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ary gercek hayatta cok fazla hatta hic kullanilmaz, nedeni ise veriyi disardan 
            //aldigimiz icin sonradan degisim oldugunda cok fazla islem yapmamizdan
            //onun yerine listeler kullaniriz.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine("--------------------------------------");


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //isimler2.Add("Halil ");      //Boyle de kullanabilirsin
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            Console.ReadKey();
        }
    }
}
