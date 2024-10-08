using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitAtivityViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitActivity OfitActivity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitactivity = await _context.OfitActivity.FirstOrDefaultAsync(m => m.Id == id);

            if (ofitactivity == null)
            {
                return NotFound();
            }
            else
            {
                OfitActivity = ofitactivity;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitactivity = await _context.OfitActivity.FindAsync(id);
            if (ofitactivity != null)
            {
                OfitActivity = ofitactivity;
                _context.OfitActivity.Remove(OfitActivity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
