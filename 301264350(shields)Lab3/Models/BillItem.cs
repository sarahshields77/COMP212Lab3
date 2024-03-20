using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301264350_shields_Lab3.Models
{
    public class BillItem
    {
        public BillItem()
        {
            Name = ""; // default to empty string
            Category = "";
            Quantity = 1; // initialize Quantity to 1
        }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name; // can customize to include other BillItem properties 
        }

    }
}
