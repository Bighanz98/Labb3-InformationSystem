using Labb3_InformationSystem.Models;
using Labb3_InformationSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_InformationSystem.Controllers
{
    [Authorize] // Kräver inloggning för alla metoder
    public class DriverController : Controller
    {
        private readonly IDriverRepository _driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        // GET: Driver
        public async Task<IActionResult> Index(string searchName)
        {
            var drivers = await _driverRepository.GetAllDriversAsync();

            if (!string.IsNullOrEmpty(searchName))
            {
                drivers = drivers.Where(d => d.DriverName.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            ViewData["SearchName"] = searchName; // Spara söksträngen för att använda den i vyn
            return View(drivers);
        }

        // GET: Driver/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Driver/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Driver driver)
        {
            if (ModelState.IsValid)
            {
                await _driverRepository.AddDriverAsync(driver);
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        // GET: Driver/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var driver = await _driverRepository.GetDriverByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        // POST: Driver/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Driver driver)
        {
            if (id != driver.DriverID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _driverRepository.UpdateDriverAsync(driver);
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        // GET: Driver/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var driver = await _driverRepository.GetDriverByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        // POST: Driver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _driverRepository.DeleteDriverAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Driver/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var driver = await _driverRepository.GetDriverByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }
    }
}