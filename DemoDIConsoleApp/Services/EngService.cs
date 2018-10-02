using System;

namespace DemoDIConsoleApp.Services
{
    public class EngService : IService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
