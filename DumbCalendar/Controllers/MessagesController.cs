using Microsoft.AspNetCore.Mvc;

namespace DumbCalendar.Controllers
{
    public class MessagesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}