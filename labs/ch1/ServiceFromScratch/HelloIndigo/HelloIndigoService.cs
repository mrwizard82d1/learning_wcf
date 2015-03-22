using System.ServiceModel;

namespace HelloIndigo
{
    public interface IHelloIndigoService
    {
        string HelloIndigo();
    }

    /// <summary>
    /// An service contract on the concrete, implementing class.
    /// </summary>
    [ServiceContract(
        Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public class HelloIndigoService
    {
        [OperationContract]
        public string HelloIndigo()
        {
            return "Hello, Indigo!";
        }
    }
}
