using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;

namespace razor_demo.Pages.OfitAtivityViews
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
            return Page();
        }

        [BindProperty]
        public OfitActivity OfitActivity { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine(ModelState);
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfitActivity.Add(OfitActivity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
