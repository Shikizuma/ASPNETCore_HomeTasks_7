using ASPNETCore_HomeTasks_7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace ASPNETCore_HomeTasks_7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonModel model)
        {
            //Console.WriteLine($"First: {model.First}, Second: {model.Second}, Count: {model.Count}");
            System.Diagnostics.Debug.WriteLine($"First: {model.First}, Second: {model.Second}, Count: {model.Count}");
            return View();
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}