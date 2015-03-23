
using System;
using System.Diagnostics;
using System.ServiceModel;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Host.Specs
{
    /// <summary>
    /// An **copy** of the interface specifying the contract for this service.
    /// </summary>
    [ServiceContract(
        Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }

    [Binding]
    public class RunServiceHostSteps
    {
        [Given(@"that I have started the host")]
        public void GivenThatIHaveStartedTheHost()
        {
            Process.Start(@"..\..\..\Host\bin\Debug\Host.exe");
        }

        [When(@"I execute the ""(.*)"" method of the service")]
        public void WhenIExecuteTheMethodOfTheService(string p0)
        {
            var endPointAddress =
                new EndpointAddress(
                    "http://localhost:8000/HelloIndigo/HelloIndigoService");
            var proxy =
                ChannelFactory<IHelloIndigoService>.CreateChannel(
                    new BasicHttpBinding(), 
                    endPointAddress);
            ScenarioContext.Current.Set(proxy);
        }
        
        [Then(@"I receive ""(.*)"" as a result")]
        public void ThenIReceiveAsAResult(string p0)
        {
            var proxy = ScenarioContext.Current.Get<IHelloIndigoService>();
            var result = proxy.HelloIndigo();
            Assert.That(result, Is.EqualTo("Hello Indigo"));
        }
    }
}
