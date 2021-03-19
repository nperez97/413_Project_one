using _413_Project_one.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _413_Project_one.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;
        //repository
        private IGroupRepository _repository;
        public HomeController(ILogger<HomeController> logger, IGroupRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }*/

        private BookingDBContext context { get; set; }

        //Constructor
        public HomeController(BookingDBContext con)
        {
            context = con;
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
        public IActionResult NewAppointment(Group newGroup, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                /*studentRepository.InsertStudent(student);
                studentRepository.Save();*/
                //Repository.AddResponse(newGroup);

                context.Groups.Add(newGroup);
                context.SaveChanges();
                //change id to int since it would normally return a string
                int Appt_id = Int32.Parse(form["id"]);
                var appt = context.Appointments.SingleOrDefault(a => a.AppointmentID == Appt_id);
                if (appt != null)
                {
                    appt.Booked = true;
                    context.SaveChanges();
                }
                
                //(context.Appointments.Where(a => a.AppointmentID == Appt_id);
                Response.Redirect("Index");
            }
            //code to keep appt time populated if they incorrectly put in phone.
            ViewData["id"] = form["id"];
            ViewData["appTime"] = form["GroupAppointmentTime"];
            return View();
        }

        
        public IActionResult ViewAppointments()
        {
            return View(context.Groups); 
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(context.Appointments.OrderBy(e => e.AppointmentStartTime));
        }

        [HttpPost]
        public IActionResult SignUp(IFormCollection form)
        {
            ViewData["id"] = form["id"];
            ViewData["appTime"] = form["time"];

            return View("NewAppointment");
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