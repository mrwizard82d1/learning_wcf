using System;
using System.ServiceModel;
using HelloIndigo;

namespace Host
{
    class Program
    {
        static void Main()
        {
            // This Servicehost constructor **does not** specify a base
            // address for the service. Consequently, the developer must
            // supply the complete URI when constructing the service 
            // endpoint.
            using (
                var host = new ServiceHost(typeof (HelloIndigoService)))
            {
                // Because the ServiceHost constructor **did not** 
                // specify a URI, the service has **no** base address. 
                // As a consequence, the call to `AddServiceEndpoint` must
                // include the completely specified URI of the service.
                host.AddServiceEndpoint(typeof (IHelloIndigoService),
                    new BasicHttpBinding(),
                    "http://localhost:8000/HelloIndigo/HelloIndigoService");
                host.Open();

                Console.WriteLine(
                    "Press <ENTER> to terminate the service host.");
                Console.ReadLine();
            }
        }
    }
}
