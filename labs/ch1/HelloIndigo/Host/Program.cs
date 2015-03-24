using System;
using System.ServiceModel;
using HelloIndigo;

namespace Host
{
    class Program
    {
        static void Main()
        {
            // Note that one must create a ServiceHost using the concrete
            // implementation of the service (not the interface as I keep
            // wanting to type :)).
            using (var host = new ServiceHost(typeof(HelloIndigoService)))
            {
                host.Open();

                Console.WriteLine("Press <ENTER> to terminate host.");
                Console.ReadLine();
            }
        }
    }
}
