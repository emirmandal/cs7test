﻿using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public class Person : Object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfAncientWorld FavouriteAncientwonder;
        public WondersOfAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants

        public const string Species = "Homo Sapien";


    }
}
