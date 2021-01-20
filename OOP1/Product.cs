using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } // snippet --> hazır kodlar 
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double UnitPrice { get; set; } // birim fiyatı
        public int UnitInStock { get; set; }
    }
}
