using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using FamilyBunker;
using FamilyBunker.Entities;

namespace FamilyBunker.Controllers
{
    public class groceryListsController : Controller
    {
        private readonly FamilyBunkerContext _context;

        public groceryListsController(FamilyBunkerContext context)
        {
            _context = context;
        }

        // GET: groceryLists
        public async Task<IActionResult> Index()
        {
            //return View(await _context.groceryLists.Where(x => x.FamilyCodeName == "lohndoesfamily").ToListAsync());
            return View(await _context.groceryLists.Where(x => x.FamilyCodeName == User.Claims.FirstOrDefault(y => y.Type == "FamilyCodeName").Value).ToListAsync());
        }

        // GET: groceryLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.groceryLists
                .FirstOrDefaultAsync(m => m.groceryId == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // GET: groceryLists/Create
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

        // POST: groceryLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("groceryId,itemName,quantity,FamilyCodeName,memberId")] groceryList groceryList)
        {
            if (ModelState.IsValid)
            {
                groceryList.FamilyCodeName = User.Claims.FirstOrDefault(x => x.Type == "FamilyCodeName").Value;
                _context.Add(groceryList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groceryList);
        }

        // GET: groceryLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.groceryLists.FindAsync(id);
            if (groceryList == null)
            {
                return NotFound();
            }
            return View(groceryList);
        }

        // POST: groceryLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("groceryId,itemName,quantity,memberId")] groceryList groceryList)
        {
            if (id != groceryList.groceryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groceryList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!groceryListExists(groceryList.groceryId))
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
            return View(groceryList);
        }

        // GET: groceryLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.groceryLists
                .FirstOrDefaultAsync(m => m.groceryId == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // POST: groceryLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groceryList = await _context.groceryLists.FindAsync(id);
            _context.groceryLists.Remove(groceryList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool groceryListExists(int id)
        {
            return _context.groceryLists.Any(e => e.groceryId == id);
        }
    }
}
