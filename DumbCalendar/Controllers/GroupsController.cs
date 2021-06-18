using Microsoft.AspNetCore.Mvc;

namespace DumbCalendar.Controllers
{
    public class GroupsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}