﻿using System;
using System.Collections.Generic;

namespace Genericsintro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            
                isimler.Add("Engin");
            
            Console.ReadKey();
        }
    }
}
