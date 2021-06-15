using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class CalendarEventsRepository : ICalendarEventsRepository
    {
        public async Task<CalendarEvent> Create(CalendarEvent value)
        {
            throw new NotImplementedException();
        }

        public async Task<CalendarEvent> Update(CalendarEvent value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CalendarEvent>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CalendarEvent>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CalendarEvent>> GetBySelector(Func<CalendarEvent, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<CalendarEvent> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}