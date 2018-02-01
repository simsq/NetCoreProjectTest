using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;
using ServicesLibrary.IServices;
using ServicesLibrary.Dto;
using DataLibrary.Domain;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
            _customerService.Add(new Customer() { Username = "Jason", Password = "admin", Email = "simsq@vip.qq.com" });
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
