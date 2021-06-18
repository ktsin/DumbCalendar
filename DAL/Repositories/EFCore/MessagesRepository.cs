using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.EFCore
{
    public class MessagesRepository : IMessagesRepository
    {
        public Task<Message> Create(Message value)
        {
            throw new NotImplementedException();
        }

        public Task<Message> Update(Message value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(object key)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Message>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Message>> ReadAllInclude()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Message>> GetBySelector(Func<Message, bool> selector)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}