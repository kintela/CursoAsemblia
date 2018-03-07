using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClases
{
    public class Message
    {
        //private string name;

        public string Name {get;}

        public Message(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)=> Name.Equals(((Message)obj).Name);

        public override int GetHashCode()=> Name.GetHashCode();  

    }
}
