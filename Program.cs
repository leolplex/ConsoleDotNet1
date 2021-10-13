using System;
using WireMock.Server;

namespace ConsoleDotNet1
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = WireMockServer.Start();
            Console.WriteLine("Hello World!");
        }
    }
}
