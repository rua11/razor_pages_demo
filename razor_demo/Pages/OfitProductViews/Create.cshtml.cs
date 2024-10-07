using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;

namespace razor_demo.Pages.OfitProductViews
{
    public class CreateModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public CreateModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.OfitCategory, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public OfitProduct OfitProduct { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfitProduct.Add(OfitProduct);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
