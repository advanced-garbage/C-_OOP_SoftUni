using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private string _name;
        private int _age;
        private string _group;
        public string Name { get { return this._name; } set { this._name = value;} }
        public int Age { get { return this._age; } set { this._age = value; } }
        public string Group { get { return this._group; } set { this._group = value; } }
        public int Food { get; set; }
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public void BuyFood() => this.Food += 5;
    }
}
