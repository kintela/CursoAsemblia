using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    public class Message
    {

        private string title;
        private string body;

        public string Title
        {
            get => title;
            set => title = value.ToUpperInvariant();                       
        }

        public string Body { get; set; }

        public int Length => title.Length + body.Length;

        public void ClearTitle() => title = "";

    }
}
