using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Entities;
using TicketSystem.Interfaces;

namespace TicketSystem.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketDbContext _ticketDbContext;
        public TicketRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }
        public IEnumerable<Ticket> GetAll()
        {
            return _ticketDbContext.Tickets;
        }        
        public Ticket GetById(int Id)
        {
            var query = _ticketDbContext.Tickets.FirstOrDefault(i => i.Id == Id);
            return query;
        }
        public bool Create(Ticket ticket)
        {
            _ticketDbContext.Tickets.Add(ticket);
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
        public bool Update(Ticket ticket)
        {
            var dbTicket = _ticketDbContext.Tickets.FirstOrDefault(i => i.Id == ticket.Id);
            dbTicket.Title = ticket.Title;
            dbTicket.Description = ticket.Description;
            
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

        public bool RemoveById(int Id)
        {
            var dbTicket = _ticketDbContext.Tickets.FirstOrDefault(i => i.Id == Id);
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
    }
}
