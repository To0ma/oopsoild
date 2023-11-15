using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    internal interface IProduct
    {
        string Name { get; set; }
        DateTime CreationDate { get; set; }
        void DisplayDetails();
    }
}
