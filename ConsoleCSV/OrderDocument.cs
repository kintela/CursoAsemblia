using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace ConsoleCSV
{
    public class OrderDocument
    {
        private readonly Stream document;

        public IEnumerable<OrderItem> OrderItems
        {
            get
            {
                using (var sr = new StreamReader(document))
                {
                    var csv = new CsvReader(sr);
                    csv.Configuration.HasHeaderRecord = false;
                    csv.Configuration.Delimiter = ";";
                    while (csv.Read())
                    {
                        yield return csv.GetRecord<OrderItem>();
                    }                    
                }

            }
        }
        public OrderDocument(Stream document)
        {
            this.document = document;
        }
    }
}
