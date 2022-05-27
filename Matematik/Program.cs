using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(5, 6);
            dortislem.Topla(10, 20);

            DortIslem dortIslem = new DortIslem();
            dortIslem.Carpma(2, 6);

            Console.ReadKey();

        }
    }
}
