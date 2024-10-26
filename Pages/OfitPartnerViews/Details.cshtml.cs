using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitPartnerViews
{
    public class DetailsModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DetailsModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public OfitPartner OfitPartner { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitpartner = await _context.OfitPartner.FirstOrDefaultAsync(m => m.Id == id);
            if (ofitpartner == null)
            {
                return NotFound();
            }
            else
            {
                OfitPartner = ofitpartner;
            }
            return Page();
        }
    }
}
