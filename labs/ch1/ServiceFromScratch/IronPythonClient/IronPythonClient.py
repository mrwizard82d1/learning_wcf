import os
import clr
from System import Console
clr.AddReference('System.ServiceModel')
from System.ServiceModel import (EndpointAddress, 
                                 BasicHttpBinding, ChannelFactory)
clr.AddReferenceToFileAndPath(os.path.join
                              (os.path.abspath('../Client/bin/Debug/'),
                               'Client.exe'))
from Client import IHelloIndigoService


endpoint_address = EndpointAddress('http://localhost:8000/HelloIndigo/HelloIndigoService')
binding = BasicHttpBinding()
proxy = ChannelFactory[IHelloIndigoService].CreateChannel(binding,
                                                          endpoint_address)

result = proxy.HelloIndigo()

Console.WriteLine("IronPythonClient received ", result)
Console.WriteLine()

Console.WriteLine("Press <ENTER> to terminate IronPython client.")
Console.ReadLine()