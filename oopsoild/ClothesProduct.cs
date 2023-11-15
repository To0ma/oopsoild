using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    internal class ClothesProduct : IProduct
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Size { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Creation Date: {CreationDate}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine("------------------------------------");
        }
    }
}