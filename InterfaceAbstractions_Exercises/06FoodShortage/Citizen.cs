using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IIdentification, IBirthday, IBuyer
    {
        private string _name;
        private int _age;
        public string Name { get { return this._name; } set { this._name = value; } }
        public int Age { get { return this._age; } set { this._age = value; } }
        public string Id { get; set; }
        public string Birthday { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            this.Food = 0;
        }

        public void PrintFakeIDs() => Console.WriteLine(this.Id);
        public void PrintBirthday() => Console.WriteLine(this.Birthday);
        public void BuyFood() => this.Food += 10;
    }
}
