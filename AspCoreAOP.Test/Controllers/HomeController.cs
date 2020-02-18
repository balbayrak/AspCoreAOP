using AspCoreAOP.Test.Abstract;
using AspCoreAOP.Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreAOP.Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;


        public HomeController(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
        {
            _serviceA = serviceA;
            _serviceB = serviceB;
            _serviceC = serviceC;
        }


        public IActionResult Index()
        {
            InputDTO inputA = new InputDTO();
            inputA.str = "ServiceA";

            ViewBag.ServiceA = _serviceA.Run(inputA);

            InputDTO inputB = new InputDTO();
            inputB.str = "ServiceB";

            ViewBag.ServiceB = _serviceB.Run(inputB);


            InputDTO inputC = new InputDTO();
            inputC.str = "ServiceC";

            ViewBag.ServiceC = _serviceC.Run(inputC);

            return View();
        }
    }
}
