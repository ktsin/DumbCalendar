using System.Collections;
using System.Collections.Generic;

namespace BLL.Calendar
{
    public class Calendar
    {
        public byte MonthNumber { get; set; }
        
        public ICollection<CalendarDay> CalendarDays { get; set; }
    }
}