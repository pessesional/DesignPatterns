/********************************************************************************

* Copyright (c) Ben Wu  All Rights Reserved  (C) 2015 
* Class： FactoryMethod
* Comp：  Ben Wu
* Auth：  Ben Wu
* Date：  2016/8/17 16:22:02
* Desc：  The time constraint, Many functions not implemented.Ignore Descripion
* Vers:   V1.0.0

*********************************************************************************/

using System;

namespace FactoryMethod
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// 子类中实现要生产的产品
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract T CreateProduct<T>() where T:new ();
    }

}
