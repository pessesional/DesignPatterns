/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： Simple_Factory
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 19:31:14
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

namespace Simple_Factory
{
    public class SimpleFactory
    {
           //简单工厂  
            public static T CreateProduct<T>() where T : new()
            {
               return new T();
            }
    }
}
