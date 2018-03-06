using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace ConsoleCSV
{
    class Program
    {
        static void Main2(string[] args)
        {
            //string path = "C:\\borrame\\ejemplo.csv";
            //string fileName = @"C:\borrame\ejemplo.csv";

            //List<OrderDocument> orderDocumentList = new List<OrderDocument>();

            //using (TextReader filereader = File.OpenText(fileName))
            //{
            //    var csv = new CsvReader(filereader);
            //    csv.Configuration.HasHeaderRecord = false;
            //    csv.Configuration.Delimiter = ";";
            //    while (csv.Read())
            //    {
            //        var id = csv.GetField<int>(0);
            //        var cantidad = csv.GetField<int>(1);
            //        var codigoArticulo = csv.GetField<string>(2);

            //        OrderDocument od = new OrderDocument();

            //        od.Id = id;
            //        od.Cantidad = cantidad;
            //        od.CodigoArticulo = codigoArticulo;

            //        orderDocumentList.Add(od);
            //    }
            //}           
        }

        static void Main3(string[] args)
        {
            string fileName = @"C:\borrame\ejemplo.csv";

            List<OrderDocument> orderDocumentList = new List<OrderDocument>();

            using (var sr=new StreamReader(fileName))
            {
                var csv = new CsvReader(sr);
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.Delimiter = ";";
                IEnumerable<OrderDocument> records = csv.GetRecords<OrderDocument>().ToList();
               
            }
        }

        static void Main(string[] args)
        {
            string fileName = @"C:\borrame\ejemplo.csv";

            OrderDocument od = new OrderDocument(File.Open(fileName,FileMode.Open));

            
            Console.WriteLine(od.OrderItems.Where(c=>c.Id==1).FirstOrDefault().Id);
            

            Console.ReadLine();
        }
    }
}
