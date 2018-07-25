using Packt.CS7;
using static System.Console;
using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new System.DateTime(1965, 12, 22);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");

            var p2 = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:dddd, d MMM yyy}");

            p1.FavouriteAncientwonder = WondersOfAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientwonder}");

            // p1.BucketList = WondersOfAncientWorld.HangingGardensOfBabylon | WondersOfAncientWorld.MausoleumAtHalicarnassus;
            p1.BucketList = (WondersOfAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");
        }
    }
}
