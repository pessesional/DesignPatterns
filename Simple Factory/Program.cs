﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = SimpleFactory.CreateProduct<ProductOne>();
            factory.DoSomething();

            Console.ReadLine();
        }
    }
}
