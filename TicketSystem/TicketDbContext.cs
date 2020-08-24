using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Entities;

namespace TicketSystem
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
