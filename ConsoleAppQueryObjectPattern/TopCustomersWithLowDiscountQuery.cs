using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppQueryObjectPattern
{
    public class TopCustomersWithLowDiscountQuery
    {
        public bool IncludePreferred { get; set; }
        public decimal DiscountThreshold { get; set; }
        public int SalesThreshold { get; set; }

        public Expression<Func<Customer, bool>> AsExpression()
        {
            return (c=>
                    c.Preferred==IncludePreferred
                    && c.Discount<DiscountThreshold
                    && c.AnnualSales>SalesThreshold);
        }
    }
}
