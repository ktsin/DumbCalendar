using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BLL.DTO
{
    [Keyless]
    public class CalendarEventDTO
    {
        public string OwnerId { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public string Comment { get; set; }
        
        public ICollection<TagDTO> Tags { get; set; }
            
    }
}
