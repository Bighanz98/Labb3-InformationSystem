using Labb3_InformationSystem.Models;

namespace Labb3_InformationSystem.Services
{
    public interface INotificationRepository
    {
        List<Event> GetRecentEventsForEmployee();
        List<Event> GetRecentEventsForAdmin();
    }
}
