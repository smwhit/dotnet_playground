using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace WCFLargeFileAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(FileUploadService));
            serviceHost.Open();
            Console.WriteLine("Press <ENTER> to terminate\n\n");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
