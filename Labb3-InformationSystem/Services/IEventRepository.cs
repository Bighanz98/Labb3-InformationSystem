using Labb3_InformationSystem.Models;

namespace Labb3_InformationSystem.Services
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task AddEventAsync(Event newEvent); 
        Task UpdateEventAsync(Event existingEvent); 
        Task DeleteEventAsync(int id);
    }
}
