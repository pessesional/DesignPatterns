/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： FactoryMethod
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 16:46:55
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

namespace FactoryMethod
{
    using System;
    public class Bread : Product
    {
        public Bread()
            : this("Bread")
        {
        }

        public Bread(string productName)
        {
            Name = productName;
        }


        public void Manufacture()
        {
            Console.WriteLine(string.Format("正在生产{0}", Name));
        }
    }
}
