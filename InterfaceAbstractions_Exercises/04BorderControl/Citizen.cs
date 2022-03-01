using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentification
    {
        private string _name;
        private int _age;
        public string Name { get { return this._name; } set { this._name = value; } }
        public int Age { get { return this._age; } set { this._age = value; } }
        public string Id { get; set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public void PrintFakeIDs() => Console.WriteLine(this.Id);
    }
}
