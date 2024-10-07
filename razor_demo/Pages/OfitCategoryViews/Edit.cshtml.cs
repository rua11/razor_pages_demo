using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitCategoryViews
{
    public class EditModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public EditModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitCategory OfitCategory { get; set; } = default!;
        public SelectList CategoryTypes { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcategory =  await _context.OfitCategory.FirstOrDefaultAsync(m => m.Id == id);
            CategoryTypes = new SelectList(Enum.GetValues(typeof(CategoryType1)));
            if (ofitcategory == null)
            {
                return NotFound();
            }
            OfitCategory = ofitcategory;
            ViewData["ParentId"] = new SelectList(_context.OfitCategory, "Id", "Name");
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

            _context.Attach(OfitCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfitCategoryExists(OfitCategory.Id))
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

        private bool OfitCategoryExists(int id)
        {
            return _context.OfitCategory.Any(e => e.Id == id);
        }
    }
}
