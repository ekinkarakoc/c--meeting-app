using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.username = "Ekin";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Antalya, AKM Kongre Merkezi",
                Date = new DateTime(2025, 09, 02, 20, 0, 0),
                NumberOfPeople = 100,
            };


            return View(meetingInfo);
        }
    }
}
