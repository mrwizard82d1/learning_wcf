using System.ServiceModel;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to 
    // change the interface name "IHelloIndigoService" in both code and 
    // config file together.
    //
    // By default, the WCF Service Visual Studio template **does not** add
    // a namespace to the service contract. Adding a namespace allows one
    // to distinguish services by the namespace. In addition, the namespace
    // URI supports versioning. Specifically, the domain, 
    // www.thatindigogirl.com, isolates our service from other identically
    // named services. Furthermore, `samples` further encapsulate the 
    // service name. Finally, the `2006/06` supports versioning of the 
    // service by time.
    [ServiceContract(
        Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        /// <returns>The greeting for this service.</returns>
        [OperationContract]
        string HelloIndigo();
    }
}
