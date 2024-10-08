using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitMaterialViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitMaterial OfitMaterial { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitmaterial = await _context.OfitMaterial.FirstOrDefaultAsync(m => m.Id == id);

            if (ofitmaterial == null)
            {
                return NotFound();
            }
            else
            {
                OfitMaterial = ofitmaterial;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitmaterial = await _context.OfitMaterial.FindAsync(id);
            if (ofitmaterial != null)
            {
                OfitMaterial = ofitmaterial;
                _context.OfitMaterial.Remove(OfitMaterial);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
