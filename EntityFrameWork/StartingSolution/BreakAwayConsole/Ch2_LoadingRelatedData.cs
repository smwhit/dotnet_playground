using System;
using System.Linq;
using System.Data.Entity;
using DataAccess;

namespace BreakAwayConsole
{
    public class Ch2_LoadingRelatedData
    {
        public static void TestLazyLoading()
        {
            // need to mark the collection as virtual so dynamic proxy can overwrite.
            using (var context = new BreakAwayContext())
            {
                var query = context.Destinations.Where(x => x.Name == "Grand Canyon");

                var canyon = query.Single();

                Console.WriteLine("Grand Canyon Lodgings");
                foreach (var lodging in canyon.Lodgings)
                {
                    Console.WriteLine(lodging.Name);
                }
            }
        }

        public static void BadLazyLoading()
        {
            //Select N+1
            using (var context = new BreakAwayContext())
            {
                foreach (var destination in context.Destinations)
                {
                    Console.WriteLine("Destination: {0}", destination.Name);
                    foreach (var lodging in destination.Lodgings)
                    {
                        Console.WriteLine("Loading: {0}", lodging.Name);
                    }
                }
            }
        }

        public static void TestEagerLoading()
        {
            using (var context = new BreakAwayContext())
            {
                var allDestinations = context.Destinations.Include(x => x.Lodgings);
                foreach (var destination in allDestinations)
                {
                    Console.WriteLine(destination.Name);
                    foreach (var lodging in destination.Lodgings)
                    {
                        Console.WriteLine(" - " + lodging.Name);
                    }
                }
            }

        }
    }
}