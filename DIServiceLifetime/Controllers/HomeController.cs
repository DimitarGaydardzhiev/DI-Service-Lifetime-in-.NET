using DIServiceLifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIServiceLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService singletonService;

        private readonly ITransientService transientService;

        private readonly IScopedService scopedService;

        private readonly IComplexService complexService;

        public HomeController(
            ISingletonService singletonService, 
            ITransientService transientService, 
            IScopedService scopedService,
            IComplexService complexService)
        {
            this.singletonService = singletonService;
            this.transientService = transientService;
            this.scopedService = scopedService;
            this.complexService = complexService;
        }

        public IActionResult Index(IDictionary<string, string> model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Data()
        {
            var servicesData = new Dictionary<string, string>();
            servicesData.Add("SingletonService", this.singletonService.Id);
            servicesData.Add("TransientService", this.transientService.Id);
            servicesData.Add("ScopedService", this.scopedService.Id);
            ViewBag.ComplexService = this.complexService;
            
            return View("Index", servicesData);
        }
    }
}