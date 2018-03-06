using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGenerics
{
    public class Animal:IIdentity
    {
        public string Alias { get; set; }
        public int Id { get ; set; }
    }
}
