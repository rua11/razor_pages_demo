using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;

namespace razor_demo.Pages.OfitCategoryViews
{
    public class CreateModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public CreateModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        // Holds the available category types as a dropdown list
        public SelectList CategoryTypes { get; set; }

        public IActionResult OnGet()
        {
        ViewData["ParentId"] = new SelectList(_context.OfitCategory, "Id", "Name");
        CategoryTypes = new SelectList(Enum.GetValues(typeof(CategoryType1)));
            return Page();
        }

        [BindProperty]
        public OfitCategory OfitCategory { get; set; } = default!;



        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfitCategory.Add(OfitCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
