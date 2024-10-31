using Labb3_InformationSystem.Data;
using Labb3_InformationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_InformationSystem.Services
{
    public class EventRepository : IEventRepository
    {

        private readonly AppDbContext _context;


        public EventRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEventAsync(Event newEvent)
        {
            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            if (eventToDelete != null)
            {
                _context.Events.Remove(eventToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await _context.Events.Include(e => e.Driver).ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _context.Events.Include(e => e.Driver).FirstOrDefaultAsync(e => e.EventID == id);
        }

        public async Task UpdateEventAsync(Event existingEvent)
        {
            _context.Events.Update(existingEvent);
            await _context.SaveChangesAsync();
        }
    }
}
