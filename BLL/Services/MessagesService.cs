using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using DAL.Repositories.Interfaces;

namespace BLL.Services
{
    public class MessagesService
    {
        private readonly IMessagesRepository _messagesRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public MessagesService(IMessagesRepository messagesRepository,
            IUserRepository userRepository, 
            IMapper mapper)
        {
            _messagesRepository = messagesRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<UserDTO>> GetConversationsList(object userId)
        {
            var msgs = await _messagesRepository.GetBySelector(e => e.Sender.Equals(userId)
                                                              || e.Recipient.Equals(userId));
            var conversationsWith = await Task.Run(() => msgs?
                .SelectMany(e => new string[] {e?.Recipient, e?.Sender})
                .Distinct()
                .Except(new[] {userId as string}).Select(e=>_userRepository.GetById(e).Result).ToList());
            return conversationsWith;
        }  
        
        
    }
}