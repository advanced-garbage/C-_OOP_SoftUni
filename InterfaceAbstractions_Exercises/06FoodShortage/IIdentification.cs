using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IIdentification
    {
        string Id { get; set; }
        void PrintFakeIDs() { }
    }
}
