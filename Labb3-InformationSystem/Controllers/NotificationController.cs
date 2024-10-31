using Labb3_InformationSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_InformationSystem.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationController(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public IActionResult Index()
        {
            var notifications = User.IsInRole("Admin")
                ? _notificationRepository.GetRecentEventsForAdmin()
                : _notificationRepository.GetRecentEventsForEmployee();

            return View(notifications);
        }
    }
}