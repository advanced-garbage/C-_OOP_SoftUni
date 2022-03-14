using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public abstract class Prototype
    {
        private string id;
        protected Prototype(string id)
        {
            this.id = id;
        }
        public string Id { get { return this.id; } }

        public abstract Prototype Clone();
    }
}
