using AutoMapper;
using DAL.Repositories.Interfaces;

namespace BLL.Calendar
{
    public class CalendarService
    {
        private readonly ICalendarEventsRepository _calendarEvents;
        private readonly IProjectTasksRepository _projectTasks;
        private readonly IProjectsRepository _projects;
        private readonly IMapper _mapper;

        public CalendarService(ICalendarEventsRepository calendarEvents,
            IProjectTasksRepository projectTasks,
            IProjectsRepository projects,
            IMapper mapper)
        {
            _calendarEvents = calendarEvents;
            _projectTasks = projectTasks;
            _projects = projects;
            _mapper = mapper;
        }
    }
}