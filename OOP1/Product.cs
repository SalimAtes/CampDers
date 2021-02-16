using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{//prop altı 3 nokta = snippet//
    class Product //entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsİnStock { get; set; }

    }
}
