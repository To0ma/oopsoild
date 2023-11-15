using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    internal class FoodProduct : IProduct
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string ExpirationDate { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Creation Date: {CreationDate}");
            Console.WriteLine($"Expiration Date: {ExpirationDate}");
            Console.WriteLine("------------------------------------");
        }
    }
}