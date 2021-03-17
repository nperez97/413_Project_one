using _413_Project_one.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace _413_Project_one.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //repository
        private IGroupRepository _repository;
        public HomeController(ILogger<HomeController> logger, IGroupRepository repository)
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
        public IActionResult NewAppointment(Group newGroup)
        {
            Repository.AddResponse(newGroup);
            if (ModelState.IsValid)
            {
                Response.Redirect("NewAppointment");
            }
            return View("Group", newGroup);
        }
        public IActionResult ViewAppointments()
        {
            return View(Repository.Responses); //change from title to whatever our name is
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