using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jello.Data;
using Microsoft.EntityFrameworkCore;

namespace Jello.Models
{
    public class TicketModel
    {

        private readonly ApplicationDbContext _dbContext;
        public TicketModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> DeleteTicket(Guid id)
        {
            var ticket = _dbContext.Tickets.FirstOrDefault(x => x.Id == id);
            if (ticket != null)
            {
                _dbContext.Tickets.Remove(ticket);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _dbContext.Tickets.ToListAsync();
        }

        public async Task<Ticket>  GetTicketById(Guid id)
        {
            var ticket = await _dbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
            return ticket;
        }

        public async Task<bool> SaveTicket(Ticket ticket)
        {
            if (ticket.Id.Equals(0)) {
                ticket.Id = new Guid();
                await _dbContext.Tickets.AddAsync(ticket);
            } 
            else _dbContext.Tickets.Update(ticket);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
