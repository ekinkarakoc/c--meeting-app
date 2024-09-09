using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Contollers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
