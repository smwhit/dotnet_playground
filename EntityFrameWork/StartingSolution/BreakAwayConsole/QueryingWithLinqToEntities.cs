using System;
using System.Linq;
using DataAccess;

namespace BreakAwayConsole
{
    public class Ch2QueryingWithLinqToEntities
    {
        public static void PrintAustralianDestinations()
        {
            using (var context = new BreakAwayContext())
            {
                var query = from destination in context.Destinations
                    where destination.Country == "Australia"
                    select destination;

                foreach (var destination in query)
                {
                    Console.WriteLine(destination.Name);
                }
            }
        }

        public static void PrintAllDesinationsSorted()
        {
            using (var context = new BreakAwayContext())
            {
                var query = context.Destinations.OrderBy(x => x.Name);

                foreach (var destination in query)
                {
                    Console.WriteLine(destination.Name);
                }
            }
        }

        public static void PrintAllDestinationsTwice()
        {
            using (var context = new BreakAwayContext())
            {
                var destinations = context.Destinations.ToList();

                foreach (var destination in destinations)
                {
                    Console.WriteLine(destination.Name);
                }

                foreach (var destination in destinations)
                {
                    Console.WriteLine(destination.Description);
                }
            }
        }

        public static void PrintAllDestinations()
        {
            using (var context = new BreakAwayContext())
            {
                foreach (var destination in context.Destinations)
                {
                    Console.WriteLine(destination.Name);
                }
            }
        }
    }
}