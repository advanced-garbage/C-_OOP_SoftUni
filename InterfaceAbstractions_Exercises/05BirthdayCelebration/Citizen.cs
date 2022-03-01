using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentification, IBirthday
    {
        private string _name;
        private int _age;
        public string Name { get { return this._name; } set { this._name = value; } }
        public int Age { get { return this._age; } set { this._age = value; } }
        public string Id { get; set; }
        public string Birthday { get; set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public void PrintFakeIDs() => Console.WriteLine(this.Id);
        public void PrintBirthday() => Console.WriteLine(this.Birthday);

    }
}
