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
    public class DetailsModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DetailsModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
