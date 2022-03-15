using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    // Client class - "Car"
    public class Car
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int NumOfDoors { get; set; } 

        public string City { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"CarType: {Type}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Number of doors: {NumOfDoors}");
            sb.AppendLine($"Manufactured in {City} at address: {Address}");
            return sb.ToString().TrimEnd();
        }
    }
}
