using System;
using System.ServiceModel;
using HelloIndigo;

namespace Host
{
    class Program
    {
        static void Main()
        {
            // A side effect (although perhaps documented)  of supplying 
            // a Uri to the ServiceHost contstructor is that this Uri
            // becomes the base address for the service. 
            using (
                var host = new ServiceHost(typeof (HelloIndigoService),
                    new Uri("http://localhost:8000/HelloIndigo")))
            {
                // By specifying the base address for the service when
                // constructing the ServiceHost, we can then specify 
                // endpoints using a relative address. That is, the 
                // complete address of the service is 
                // `http://localhost:8080/HelloIndigo/HelloIndigoService`.
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
