using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIEnumerable
{
    public class List2 : IEnumerable<int>
    {
        Random random = new Random();

        public IEnumerator<int> GetEnumerator()
        {
            while (true)
            {
                yield return random.Next();
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
    }

}
