using System;

namespace Client
{
    class Program
    {
        static void Main()
        {
            var proxy = new localhost.HelloIndigoServiceClient();
            var result = proxy.HelloIndigo();
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
