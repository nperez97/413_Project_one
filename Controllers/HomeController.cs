using _413_Project_one.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using 413_Project_one.Models;

namespace _413_Project_one.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //repository
        private ISignUpRepository _repository;

        public HomeController(ILogger<HomeController> logger, ISignUpRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult NewAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewAppointment(NewAppointment newAppointment)
        {
            Repository.AddResponse(newAppointment);

            if (ModelState.IsValid)
            {
                Response.Redirect("NewAppointment");
            }

            return View("NewAppointment", newAppointment);
        }
        
        public ViewAppointments ListAppointments()
        {
            return View(Repository.Responses.Where(r => r.Title)); //change from title to whatever our name is
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
