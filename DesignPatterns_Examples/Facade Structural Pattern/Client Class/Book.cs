using System;
using System.Collections.Generic;
using System.Text;

namespace Facade2.Client_Class
{
    // Client class - 'Book'
    public class Book
    {
        // Book content properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }

        // Book publication properties
        public int OriginalYearOfRelease { get; set; }
        public int EditionYear { get; set; }
        public string ProductionCompany { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Content Info: ");
            sb.AppendLine("--------------------");
            sb.AppendLine($"{Title} by {Author}\nPages: {Pages}, Genre: {Genre}");
            sb.AppendLine(Environment.NewLine);
            sb.AppendLine("Publication Info: ");
            sb.AppendLine("--------------------");
            sb.AppendLine($"Published by {ProductionCompany}, {EditionYear} edition. Originally released in {OriginalYearOfRelease}");
            return sb.ToString().TrimEnd();
        }
    }
}
