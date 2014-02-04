using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using DataAccess;
using Model;

namespace BreakAwayConsole
{
    public class Ch2_QueryLocalData
    {
        public static void GetLocalDestinationCount()
        {
            using (var context = new BreakAwayContext())
            {
                foreach (var destination in context.Destinations)
                {
                    Console.WriteLine(destination.Name);
                }

                var count = context.Destinations.Local.Count;
                Console.WriteLine("Destinations in memory: {0}", count);
            }
        }

        public static void GetLocalDestinationCountWithLoad()
        {
            using (var context = new BreakAwayContext())
            {
                context.Destinations.Load();

                Console.WriteLine("Destinations in memory: {0}", context.Destinations.Local.Count);
            }
        }

        public static void LoadAustralianDestinations()
        {
            using (var context = new BreakAwayContext())
            {
                var query = from d in context.Destinations
                    where d.Country == "Australia"
                    select d;
                query.Load();

                var count = context.Destinations.Local.Count;
                Console.WriteLine("Aussie destination local count: {0}", count);
            }
        }

        public static void LocalLinqQueries()
        {

            using (var context = new BreakAwayContext())
            {
                context.Destinations.Load();
                var sortedDestinations = context.Destinations.Local.OrderBy(x => x.Name);

                Console.WriteLine("All destinations");
                foreach (var destination in sortedDestinations)
                {
                    Console.WriteLine(destination.Name);
                }

                var aussieDestinations = context.Destinations.Local.Where(x => x.Country == "Australia");
                Console.WriteLine();
                Console.WriteLine("Australian Destinations");

                foreach (var aussieDestination in aussieDestinations)
                {
                    Console.WriteLine(aussieDestination.Name);
                }
            }
        }

        public static void ListenToLocalChanges()
        {
            using (var context = new BreakAwayContext())
            {
                context.Destinations.Local.CollectionChanged += (sender, args) =>
                {
                    if(args.NewItems != null)
                    {
                        foreach (Destination newItem in args.NewItems)
                        {
                            Console.WriteLine("Added: " + newItem.Name);
                        }
                    }

                    if (args.OldItems != null)
                    {
                        foreach (Destination oldItem in args.OldItems)
                        {
                            Console.WriteLine("Removed: " + oldItem.Name);
                        }
                    }
                };
                context.Destinations.Load();
            }
        }
    }
}