using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL.Repositories.EFCore
{
    public class ProjectTasksRepository : IProjectTasksRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<ProjectTasksRepository> _logger;

        public ProjectTasksRepository(DataContext context,
            ILogger<ProjectTasksRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ProjectTask> Create(ProjectTask value)
        {
            var res = await _context.ProjectTasks.AddAsync(value);
            var saveRes = await _context.SaveChangesAsync();
            return res?.Entity;
        }

        public async Task<ProjectTask> Update(ProjectTask value)
        {
            var res = _context.ProjectTasks.Update(value);
            var saveRes = await _context.SaveChangesAsync();
            _logger.LogDebug(new EventId(1212), res?.DebugView?.LongView);
            return res?.Entity;
        }

        public async Task<bool> Delete(object key)
        {
            var res = _context.ProjectTasks.Remove(GetById(key).Result);
            var saveRes = await _context.SaveChangesAsync();
            _logger.LogDebug(new EventId(1212), res?.DebugView?.LongView);
            return true;
        }

        public async Task<ICollection<ProjectTask>> ReadAll()
        {
            return await _context.ProjectTasks.ToListAsync();
        }

        public async Task<ICollection<ProjectTask>> ReadAllInclude()
        {
            return await _context.ProjectTasks.Include(e => e.Tags).ToListAsync();
        }

        public async Task<ICollection<ProjectTask>> GetBySelector(Func<ProjectTask, bool> selector)
        {
            return await Task.Run(() => _context.ProjectTasks.Where(selector).ToList());
        }

        public async Task<ProjectTask> GetById(object id)
        {
            return await _context.ProjectTasks.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }
    }
}