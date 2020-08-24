using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Entities;
using TicketSystem.Interfaces;

namespace TicketSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TicketDbContext _ticketDbContext;
        public UserRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }
        public bool Create(User user)
        {
            _ticketDbContext.Users.Add(user);
            try
            {
                _ticketDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return _ticketDbContext.Users;
        }

        public User GetById(int Id)
        {
            var query = _ticketDbContext.Users.FirstOrDefault(i => i.Id == Id);
            return query;
        }

        public bool RemoveById(int Id)
        {
            var dbTicket = _ticketDbContext.Users.FirstOrDefault(i => i.Id == Id);
            try
            {
                _ticketDbContext.Remove(dbTicket);
                _ticketDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(User user)
        {
            var dbTicket = _ticketDbContext.Users.FirstOrDefault(i => i.Id == user.Id);
            dbTicket.UserName = user.UserName;
            dbTicket.Password = user.Password;
            dbTicket.Role = user.Role;

            try
            {
                _ticketDbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
