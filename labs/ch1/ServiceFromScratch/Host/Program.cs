using System;
using System.ServiceModel;
using HelloIndigo;

namespace Host
{
    class Program
    {
        static void Main()
        {
            using (
                var host = new ServiceHost(typeof (HelloIndigoService),
                    new Uri("http://localhost:8000/HelloIndigo")))
            {
                host.AddServiceEndpoint(typeof (HelloIndigoService),
                    new BasicHttpBinding(), "HelloIndigoService");
                host.Open();

                Console.WriteLine(
                    "Press <ENTER> to terminate the service host.");
                Console.ReadLine();
            }
        }
    }
}
