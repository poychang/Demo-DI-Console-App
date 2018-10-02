using System;

namespace DemoDIConsoleApp.Services
{
    public class ChtService : IService
    {
        public void SayHello()
        {
            Console.WriteLine("哈囉世界！");
        }
    }
}
