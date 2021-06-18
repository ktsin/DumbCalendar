using Microsoft.AspNetCore.Mvc;

namespace DumbCalendar.Controllers
{
    public class CalendarController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}