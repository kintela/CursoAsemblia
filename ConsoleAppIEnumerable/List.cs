using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIEnumerable
{
    public class List : IEnumerable<int>
    {
        //Clase privada anidada o nested
        private class ListEnumerator : IEnumerator<int>
        {
            int[] numbers = new int[] { 1, 2, 3, 5, 8, 13 };

            int position = -1;
            public int Current => numbers[position];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (position>=numbers.Length-1)
                {
                    return false;
                }

                position += 1;
                return true;
            }

            public void Reset()
            {
                position = -1;
            }
        }

        public IEnumerator<int> GetEnumerator() => new ListEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
