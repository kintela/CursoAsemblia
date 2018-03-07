using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIEnumerable
{
    public class Party:IEnumerable<Guest>
    {
        private IList<Guest> guestList;

        public Party()
        {
            guestList = new List<Guest>();
        }

        public void AddGuest(Guest guest)
        {
            guestList.Add(guest);
        }

        public IEnumerator<Guest> GetEnumerator()
        {
            foreach (var guest in guestList)
            {
                yield return guest;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
