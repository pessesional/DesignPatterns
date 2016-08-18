using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var factory1 = new FactoryOne();
            var bread1 = factory1.CreateProduct<Bread>(); 
            var clothes1 = factory1.CreateProduct<Clothes>();
     
            bread1.Manufacture();
            clothes1.Manufacture();

            var factory2 = new FactoryTwo();
            var bread2 = factory2.CreateProduct<Bread>();
            var clothes2 = factory2.CreateProduct<Clothes>();

            bread2.Manufacture();
            clothes2.Manufacture();

            Console.ReadLine();
        }
    }
}
