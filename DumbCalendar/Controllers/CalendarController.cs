using BLL.Calendar;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Index()
        {
            _ = _calendarService.ToString();
            return View(new Calendar());
        }
    }
}