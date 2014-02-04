using System;
using System.Data;
using System.Linq;
using DataAccess;

namespace BreakAwayConsole
{
    public class Ch2_FindingASingleObject
    {
        public static void FindDestination()
        {
            Console.WriteLine("Enter id of Destination to find: ");
            var id = int.Parse(Console.ReadLine());

            using (var context = new BreakAwayContext())
            {
                var destination = context.Destinations.Find(id);
                if (destination == null)
                {
                    Console.WriteLine("Destination not found.");
                }
                else
                {
                    Console.WriteLine(destination.Name);
                }
            }
        }

        public static void FindGreatBarrierReef()
        {
            using (var context = new BreakAwayContext())
            {
                var query = from destination in context.Destinations
                    where destination.Name == "Great Barrier Reef"
                    select destination;
                var reef = query.SingleOrDefault();

                if (reef == null)
                {
                    Console.WriteLine("Can't find the reef");
                }
                else
                {
                    Console.WriteLine(reef.Description);
                }
            }
        }
    }
}