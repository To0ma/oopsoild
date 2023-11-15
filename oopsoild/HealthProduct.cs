using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    internal class HealthProduct : IProduct
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string HealthProperty { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Creation Date: {CreationDate}");
            Console.WriteLine($"Health Property: {HealthProperty}");
            Console.WriteLine("------------------------------------");
        }
    }
}