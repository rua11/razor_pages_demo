using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitCategoryViews
{
    public class DeleteModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public DeleteModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OfitCategory OfitCategory { get; set; } = default!;
        public bool IsChecked { get; set; } = false; // Giá trị mặc định là false

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //check đã sử dụng hay chưa
            var ofitcatagories = await _context.OfitCategory.Where(c => c.ParentId == id).ToListAsync();
            if (ofitcatagories.Count > 0)
            {
                // Store an error message in TempData to display on the page
                TempData["DeleteError"] = "Danh mục đã được sử dụng, không thể xóa.";
                IsChecked = true;
            }


            var ofitcategory = await _context.OfitCategory.FirstOrDefaultAsync(m => m.Id == id);

            if (ofitcategory == null)
            {
                return NotFound();
            }
            else
            {
                OfitCategory = ofitcategory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofitcategory = await _context.OfitCategory.FindAsync(id);

            if (ofitcategory != null)
            {
                OfitCategory = ofitcategory;
                _context.OfitCategory.Remove(OfitCategory);
                await _context.SaveChangesAsync();
            }

           

            return RedirectToPage("./Index");
        }
    }
}
