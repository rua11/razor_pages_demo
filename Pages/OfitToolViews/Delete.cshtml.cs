using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitToolViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitTool OfitTool { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofittool = await _context.OfitTool.FirstOrDefaultAsync(m => m.Id == id);

            if (ofittool == null)
            {
                return NotFound();
            }
            else
            {
                OfitTool = ofittool;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofittool = await _context.OfitTool.FindAsync(id);
            if (ofittool != null)
            {
                OfitTool = ofittool;
                _context.OfitTool.Remove(OfitTool);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
