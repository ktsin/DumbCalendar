using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class ProjectsRepository : IProjectsRepository
    {
        public async Task<Project> Create(Project value)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> Update(Project value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Project>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Project>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Project>> GetBySelector(Func<Project, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}