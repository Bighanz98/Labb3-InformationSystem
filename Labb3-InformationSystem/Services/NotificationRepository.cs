using Labb3_InformationSystem.Data;
using Labb3_InformationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_InformationSystem.Services
{
    public class NotificationRepository : INotificationRepository
    {

        private readonly AppDbContext _context;

        public NotificationRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Event> GetRecentEventsForAdmin()
        {
            DateTime threshold = DateTime.Now.AddHours(-24); // 24 timmar för Admin
            return _context.Events
                .Include(e => e.Driver) // Ladda relaterad förare
                .Where(e => e.EventDate >= threshold)
                .ToList();
        }

        public List<Event> GetRecentEventsForEmployee()
        {
            DateTime threshold = DateTime.Now.AddHours(-12); // 12 timmar för Employee
            return _context.Events
                .Include(e => e.Driver) // Ladda relaterad förare
                .Where(e => e.EventDate >= threshold)
                .ToList();
        }
    }
}
