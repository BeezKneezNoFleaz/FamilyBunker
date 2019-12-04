using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamilyBunker;
using FamilyBunker.Entities;

namespace FamilyBunker.Controllers
{
    public class CalendarsController : Controller
    {
        private readonly FamilyBunkerContext _context;

        public CalendarsController(FamilyBunkerContext context)
        {
            _context = context;
        }

        // GET: Calendars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calendars.ToListAsync());
        }

        // GET: Calendars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars
                .FirstOrDefaultAsync(m => m.calendarId == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // GET: Calendars/Create
        public IActionResult Create()
        {
            List<SelectListItem> MemberId = new List<SelectListItem>
                {
                    new SelectListItem() { Text = "1", Selected = true, Value = "1"},
                    new SelectListItem() { Text = "2", Selected = false, Value = "2"},
                    new SelectListItem() { Text = "3", Selected = false, Value = "3"}
                };

            ViewBag.memberId = MemberId;
            return View();
        }

        // POST: Calendars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("calendarId,eventName,date,startTime,endTime,memberId")] Calendar calendar)
        {
            calendar.FamilyCodeName = User.Claims.FirstOrDefault(x => x.Type == "FamilyCodeName").Value;
            if (ModelState.IsValid)
            {
                _context.Add(calendar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calendar);
        }

        // GET: Calendars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars.FindAsync(id);
            if (calendar == null)
            {
                return NotFound();
            }
            return View(calendar);
        }

        // POST: Calendars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("calendarId,eventName,date,startTime,endTime,FamilyCodeName,memberId")] Calendar calendar)
        {
            if (id != calendar.calendarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarExists(calendar.calendarId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(calendar);
        }

        // GET: Calendars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars
                .FirstOrDefaultAsync(m => m.calendarId == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // POST: Calendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendar = await _context.Calendars.FindAsync(id);
            _context.Calendars.Remove(calendar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarExists(int id)
        {
            return _context.Calendars.Any(e => e.calendarId == id);
        }
    }
}
