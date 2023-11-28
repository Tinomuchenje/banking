using BankAPI.Application.Models;
using Coravel.Events.Interfaces;

namespace BankAPI.Application.Events
{

    public class UserCreated : IEvent
    {
        public User User { get; set; }

        public UserCreated(User user)
        {
            this.User = user;
        }
    }
}
