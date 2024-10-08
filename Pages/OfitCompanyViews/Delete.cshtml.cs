using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitCompanyViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitCompany OfitCompany { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcompany = await _context.OfitCompany.FirstOrDefaultAsync(m => m.Id == id);

            if (ofitcompany == null)
            {
                return NotFound();
            }
            else
            {
                OfitCompany = ofitcompany;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcompany = await _context.OfitCompany.FindAsync(id);
            if (ofitcompany != null)
            {
                OfitCompany = ofitcompany;
                _context.OfitCompany.Remove(OfitCompany);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
