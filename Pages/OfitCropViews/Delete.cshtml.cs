using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitCropViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitCrop OfitCrop { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcrop = await _context.OfitCrop.FirstOrDefaultAsync(m => m.Id == id);

            if (ofitcrop == null)
            {
                return NotFound();
            }
            else
            {
                OfitCrop = ofitcrop;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcrop = await _context.OfitCrop.FindAsync(id);
            if (ofitcrop != null)
            {
                OfitCrop = ofitcrop;
                _context.OfitCrop.Remove(OfitCrop);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
