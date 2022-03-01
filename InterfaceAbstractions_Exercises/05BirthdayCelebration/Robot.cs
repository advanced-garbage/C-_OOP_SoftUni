using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIdentification
    {
        private string _model;
        public string Model { get { return this._model; } set { this._model = value; } }  
        public string Id {get;set;}
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public void PrintFakeIDs() => Console.WriteLine(this.Id);

    }
}
