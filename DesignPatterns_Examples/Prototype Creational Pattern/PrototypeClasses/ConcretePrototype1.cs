﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.PrototypeClasses
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
