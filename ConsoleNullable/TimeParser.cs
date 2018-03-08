using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNullable
{
    public class TimeParser
    {
        private readonly string time;
        
        public TimeParser(string time)
        {
            //if (String.IsNullOrEmpty(time))
            //{
            //    throw new ArgumentNullException();
            //}

            //this.time = time;

            this.time = String.IsNullOrEmpty(time) ? throw new ArgumentNullException() : time;
        }

        private object cualquierCosa;
        public TimeParser(object cualquierCosa)
        {
            //if (cualquierCosa==null)
            //{
            //    throw new ArgumentNullException(nameof(cualquierCosa));
            //}

            //this.cualquierCosa = cualquierCosa == null ? throw new ArgumentNullException(nameof(cualquierCosa)) : cualquierCosa;

            //this.cualquierCosa = cualquierCosa ?? throw new ArgumentNullException(nameof(cualquierCosa));



        }
    }
}
