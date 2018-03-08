using System;
using System.IO;
using System.IO.Compression;

namespace ConsoleZip
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new ZipArchive(File.OpenWrite("archivo.zip"));

            var entry = d.CreateEntry("file.txt");

            File.OpenRead("file.txt").CopyTo(entry.Open());
        }
    }
}
