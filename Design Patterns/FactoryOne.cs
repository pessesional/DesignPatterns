/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： FactoryMethod
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 16:50:58
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

namespace FactoryMethod
{
    /// <summary>
    /// 工厂方法  Notice:标准工厂方法一个工厂只产生一个产品
    /// </summary>
    public class FactoryOne : Creator
    {
        public override T CreateProduct<T>()
        {
           return  new T();
        }
    }
}
