using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Security.Cryptography;
using System.Text;
using DataAccess;
using Model;

namespace BreakAwayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new InitializeBagaDatabaseWithSeedData());
            //Ch2_FindingASingleObject.FindDestination();
            //Ch2_FindingASingleObject.FindGreatBarrierReef();
            //Ch2_QueryLocalData.GetLocalDestinationCount();
            //Ch2_QueryLocalData.GetLocalDestinationCountWithLoad();
            //Ch2_QueryLocalData.LoadAustralianDestinations();
            //Ch2_QueryLocalData.LocalLinqQueries();
            //Ch2_QueryLocalData.ListenToLocalChanges();

            //Ch2_LoadingRelatedData.TestLazyLoading();
            //Ch2_LoadingRelatedData.BadLazyLoading();
            //Ch2_LoadingRelatedData.TestEagerLoading();
            // Call the latest example method here

            // NOTE: Some examples will change data in the database. Ensure that you only call the 
            //       latest example method. The InitializeBagaDatabaseWithSeedData database initializer 
            //       (registered above) will take care of resetting the database before each run.
        }

      

        // Add example methods here
    }
}
