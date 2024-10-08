using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitUnitViews
{
    public class EditModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public EditModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitUnit OfitUnit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitunit =  await _context.OfitUnit.FirstOrDefaultAsync(m => m.Id == id);
            if (ofitunit == null)
            {
                return NotFound();
            }
            OfitUnit = ofitunit;
           ViewData["CategoryId"] = new SelectList(_context.OfitCategory, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OfitUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfitUnitExists(OfitUnit.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OfitUnitExists(int id)
        {
            return _context.OfitUnit.Any(e => e.Id == id);
        }
    }
}
