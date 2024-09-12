using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;



namespace MeetingApp.Contollers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.CreateUser(model);
            return View("Thanks", model);

        }
        public IActionResult List()
        {
            return View();
        }
    }
}
