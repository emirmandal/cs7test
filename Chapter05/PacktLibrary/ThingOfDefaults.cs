using System;
using System.Collections.Generic;
using Packt.CS7;

namespace PacktLibrary
{
    class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingOfDefaults()
        {
            //Population = default(int); // C# 2.0 and later
            //When = default(DateTime);
            //Name = default(string);
            //People = default(List<Person>);

            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}
