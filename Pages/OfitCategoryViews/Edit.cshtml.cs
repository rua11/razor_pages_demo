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
        public bool IsReadOnly { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            // Domain parent khác id hiện tại
            var ofitcatagories = await _context.OfitCategory.Where(c => c.Id != id).ToListAsync();

            var ofitcategory =  await _context.OfitCategory.FirstOrDefaultAsync(m => m.Id == id);
            if (ofitcategory == null)
            {
                return NotFound();
            }

            // Điều kiện readonly
            if (ofitcategory.ParentId == null)
            {
                IsReadOnly = true;
            }


            OfitCategory = ofitcategory;
            ViewData["ParentId"] = new SelectList(ofitcatagories, "Id", "Name");
            CategoryTypes = new SelectList(Enum.GetValues(typeof(CategoryType1)));
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
