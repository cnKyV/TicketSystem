using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Entities;

namespace TicketSystem.Interfaces
{
   public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public bool Create(User user);
        public bool Update(User user);
        public bool RemoveById(int Id);
    }
}
