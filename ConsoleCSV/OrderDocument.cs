using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;

namespace ConsoleCSV
{
    public class OrderDocument
    {
        private int id;
        private int cantidad;
        private string codigoArticulo;

        public int Id { set => id = value; }
        public int Cantidad { set => cantidad = value; }
        public string CodigoArticulo { set => codigoArticulo = value; }

        //public OrderDocument(Stream Document)
        //{

        //}
    }
}
