using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace ConsoleCSV
{
    public class OrderDocument2
    {
        public List<OrderItem> OrderItems { get; }

        public OrderDocument2(Stream Document)
        {
            using (var sr = new StreamReader(Document))
            {
                var csv = new CsvReader(sr);
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.Delimiter = ";";
                OrderItems = csv.GetRecords<OrderItem>().ToList();
            }
        }
    }
}
