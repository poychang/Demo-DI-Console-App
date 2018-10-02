using DemoDIConsoleApp.Services;

namespace DemoDIConsoleApp
{
    public class App
    {
        private readonly IService _service;

        public App(IService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.SayHello();
        }
    }
}
