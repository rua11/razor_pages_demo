using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;

namespace razor_demo.Pages.OfitMaterialViews
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
        public OfitMaterial OfitMaterial { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            var checkName = _context.OfitMaterial.Any(x => x.Name == OfitMaterial.Name);
                if (checkName)
            {
                ModelState.AddModelError("OfitMaterial.Name", "Name matetial already exists");
            }
            var internalCode = _context.OfitMaterial.Any(x => x.InternalCode == OfitMaterial.InternalCode);
            if (internalCode)
            {
                ModelState.AddModelError("OfitMaterial.InternalCode", "Internal Code already exists");
            }
            var materialCode = _context.OfitMaterial.Any(x => x.MaterialCode == OfitMaterial.MaterialCode);
            if (materialCode)
            {
                ModelState.AddModelError("OfitMaterial.MaterialCode", "Material Code already exists");
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfitMaterial.Add(OfitMaterial);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
