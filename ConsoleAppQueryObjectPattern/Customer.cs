using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppQueryObjectPattern
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Preferred { get; set; }
        public decimal Discount { get; set; }
        public int AnnualSales { get; set; }
    }
}
