using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class GroupsRepository : IGroupsRepository
    {
        public async Task<Group> Create(Group value)
        {
            throw new NotImplementedException();
        }

        public async Task<Group> Update(Group value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Group>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Group>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Group>> GetBySelector(Func<Group, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<Group> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}