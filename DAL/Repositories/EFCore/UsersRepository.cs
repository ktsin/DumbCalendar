using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class UsersRepository : IRepository<User>
    {
        public async Task<User> Create(User value)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Update(User value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<User>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<User>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<User>> GetBySelector(Func<User, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}