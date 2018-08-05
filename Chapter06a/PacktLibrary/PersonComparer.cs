﻿using System.Collections.Generic;

namespace Packt.CS7
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Compare the name lengths...
            int temp = x.Name.Length.CompareTo(y.Name.Length);

            /// ... if they are equal ....
            if  (temp == 0)
            {
                // ...then sort by Names ....
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                // ... otherwise sory by the lenghts.
                return temp;
            }
        }
    }
}
