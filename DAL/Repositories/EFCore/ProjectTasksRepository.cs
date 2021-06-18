using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class ProjectTasksRepository : IProjectTasksRepository
    {
        public async Task<ProjectTask> Create(ProjectTask value)
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectTask> Update(ProjectTask value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<ProjectTask>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<ProjectTask>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<ProjectTask>> GetBySelector(Func<ProjectTask, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectTask> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}