using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using vsmvc2.Models;

namespace vsmvc2.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page. For user: " + _configuration["UserNameX"].ToString();

            ViewData["Environment"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            ViewData["TextValue"] = "The message is Andy Sheley: ".GetMe();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = $"Your contact page at { DateTime.Now }  for system: { _configuration["SystemName"].ToString() }";


            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
