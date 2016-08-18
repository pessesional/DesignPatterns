/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： FactoryMethod
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 17:21:28
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

namespace FactoryMethod
{
    public class FactoryTwo:Creator
    {
        public override T CreateProduct<T>()
        {
            return new T();
        }
    }
}
