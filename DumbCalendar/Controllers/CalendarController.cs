using BLL.Calendar;
using Microsoft.AspNetCore.Mvc;

namespace DumbCalendar.Controllers
{
    public class CalendarController : Controller
    {
        private readonly CalendarService _calendarService;

        public CalendarController(CalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}