﻿using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5, 6);

            dortIslem.Topla(10, 11);
        }
    }
}
