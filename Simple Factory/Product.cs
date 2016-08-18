/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： Simple_Factory
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 19:35:19
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

namespace Simple_Factory
{
    public abstract class Product
    {
        public string Name { get; set; }

        public abstract void DoSomething();
    }
}
