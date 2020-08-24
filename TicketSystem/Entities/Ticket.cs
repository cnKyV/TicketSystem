using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public User Sender { get; set; }
        public User Reciever { get; set; }
        public DateTimeOffset DateSent { get; set; }
    }
}
