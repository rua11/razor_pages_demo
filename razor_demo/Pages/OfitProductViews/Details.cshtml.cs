using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitProductViews
{
    public class DetailsModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DetailsModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public OfitProduct OfitProduct { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitproduct = await _context.OfitProduct.FirstOrDefaultAsync(m => m.Id == id);
            if (ofitproduct == null)
            {
                return NotFound();
            }
            else
            {
                OfitProduct = ofitproduct;
            }
            return Page();
        }
    }
}
