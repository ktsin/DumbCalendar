using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class TagsRepository : IRepository<Tag>
    {
        public async Task<Tag> Create(Tag value)
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> Update(Tag value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Tag>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Tag>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Tag>> GetBySelector(Func<Tag, bool> selector)
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}