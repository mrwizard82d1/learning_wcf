using System;
using System.ServiceModel;

namespace Client
{
    /// <summary>
    /// An **copy** of the interface specifying the contract for this service.
    /// </summary>
    [ServiceContract(Name = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }

    class Program
    {
        static void Main()
        {
            var endPointAddress =
                new EndpointAddress(
                    "http://localhost:8000/HelloIndigo/HelloIndigoService");
            var proxy =
                ChannelFactory<IHelloIndigoService>.CreateChannel(
                    new BasicHttpBinding(), endPointAddress);
            var result = proxy.HelloIndigo();
            Console.WriteLine(result);

            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
