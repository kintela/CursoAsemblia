using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppQueryObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = new TopCustomersWithLowDiscountQuery
            {
                IncludePreferred = true,
                DiscountThreshold = 3,
                SalesThreshold = 100000
            };

            var customerList = new List<Customer>
            {
                new Customer {Id=1,Name="Roberto", Preferred=true, Discount=2,AnnualSales=300000},
                new Customer {Id=2,Name="Pedro",Preferred=false, Discount=2,AnnualSales=300000},
                new Customer {Id=3,Name="Luis",Preferred=true, Discount=2,AnnualSales=300000},
            };

            var filteredCustomers = customerList.AsQueryable().Where(query.AsExpression()).ToList();

            Console.WriteLine(string.Join(",",$"{filteredCustomers.Select(c=>c.Name)}"));

            Console.ReadLine();


        }
    }
}
