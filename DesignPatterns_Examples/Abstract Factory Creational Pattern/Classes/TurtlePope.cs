using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    public class TurtlePope : IAnimal
    {
        public string Speak()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ah, hello and welcome to the Church of Vows.");
            sb.AppendLine($"Sorry for the unseeming state of affairs, but");
            sb.AppendLine($"please feel free to look around.");
            return sb.ToString().Trim();
        }
    }
}
