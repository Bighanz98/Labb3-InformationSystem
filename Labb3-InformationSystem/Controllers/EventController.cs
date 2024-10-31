using Labb3_InformationSystem.Models;
using Labb3_InformationSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_InformationSystem.Controllers
{
    [Authorize] // Kräver inloggning för alla metoder
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly IDriverRepository _driverRepository;

        public EventController(IEventRepository eventRepository, IDriverRepository driverRepository)
        {
            _eventRepository = eventRepository;
            _driverRepository = driverRepository;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            var events = await _eventRepository.GetAllEventsAsync();
            return View(events);
        }

        // GET: Event/Create
        public async Task<IActionResult> Create()
        {
            var drivers = await _driverRepository.GetAllDriversAsync();
            ViewBag.Drivers = drivers; // Skickar listan av förare till vyn
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event eventObj)
        {
            if (ModelState.IsValid)
            {
                await _eventRepository.AddEventAsync(eventObj);
                return RedirectToAction(nameof(Index));
            }
            return View(eventObj);
        }

        // GET: Event/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var eventObj = await _eventRepository.GetEventByIdAsync(id);
            if (eventObj == null)
            {
                return NotFound();
            }

            // Hämta förare och skicka till vyn
            var drivers = await _driverRepository.GetAllDriversAsync();
            ViewBag.Drivers = drivers; // Skickar listan av förare till vyn

            return View(eventObj);
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Event eventObj)
        {
            if (id != eventObj.EventID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _eventRepository.UpdateEventAsync(eventObj);
                return RedirectToAction(nameof(Index));
            }
            return View(eventObj);
        }

        // GET: Event/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var eventObj = await _eventRepository.GetEventByIdAsync(id);
            if (eventObj == null)
            {
                return NotFound();
            }
            return View(eventObj);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _eventRepository.DeleteEventAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Event/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var eventObj = await _eventRepository.GetEventByIdAsync(id);
            if (eventObj == null)
            {
                return NotFound();
            }
            return View(eventObj);
        }
    }
}