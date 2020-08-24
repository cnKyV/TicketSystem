using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Entities;

namespace TicketSystem.Interfaces
{
    public interface ITicketRepository
    {
        public IEnumerable<Ticket> GetAll();
        public Ticket GetById(int id);
        public bool Create(Ticket ticket);
        public bool Update(Ticket ticket);
        public bool RemoveById(int Id);
    }
}
