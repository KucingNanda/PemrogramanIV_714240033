using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240033
{
    class ProductTest_714240033
    {
        static void Main(string[] args)
        {
            Book_714240033 product1 = new Book_714240033("Book", "C# Object Oriented Solution", "300");
            DVD_714240033 product2 = new DVD_714240033("Ethernal Sunshine of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
