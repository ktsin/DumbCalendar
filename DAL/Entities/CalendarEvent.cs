using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    [Keyless]
    public class CalendarEvent
    {
        public string OwnerId { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public string Comment { get; set; }
        
        public ICollection<Tag> Tags { get; set; }
            
    }
}
