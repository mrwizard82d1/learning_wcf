using System.ServiceModel;

namespace HelloIndigo
{
    /// <summary>
    /// An interface specifying the contract for this service.
    /// </summary>
    [ServiceContract(Name="http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }

    public class HelloIndigoService : IHelloIndigoService
    {
        public string HelloIndigo()
        {
            return "Hello, Indigo!";
        }
    }
}
