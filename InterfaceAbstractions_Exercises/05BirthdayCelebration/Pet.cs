using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirthday
    {
        private string _name;
        public string Name { get { return this._name; } set { this._name = value; } }
        public string Birthday { get; set; }
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public void PrintBirthday() => Console.WriteLine(this.Birthday);
    }
}
