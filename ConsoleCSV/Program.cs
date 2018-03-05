using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace ConsoleCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\borrame\\ejemplo.csv";
            string fileName = @"C:\borrame\ejemplo.csv";

            List<OrderDocument> orderDocumentList = new List<OrderDocument>();

            using (TextReader filereader = File.OpenText(fileName))
            {
                var csv = new CsvReader(filereader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read())
                {
                    var id = csv.GetField<int>(0);
                    var cantidad = csv.GetField<int>(1);
                    var codigoArticulo = csv.GetField<string>(2);

                    OrderDocument od = new OrderDocument();

                    od.Id = id;
                    od.Cantidad = cantidad;
                    od.CodigoArticulo = codigoArticulo;

                    orderDocumentList.Add(od);
                }
            }
            

        }
    }
}
