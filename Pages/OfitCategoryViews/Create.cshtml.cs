using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;
using razor_demo.DataInitial;

namespace razor_demo.Pages.OfitCategoryViews
{
    public class CreateModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;
        private readonly ValidateData _validateData;
        public CreateModel(razor_demo.Data.AppDbContext context, ValidateData validateData)
        {
            _context = context;
            _validateData = validateData;
        }

        public bool IsChecked { get; set; } = true; // Giá trị mặc định là true

        // Holds the available category types as a dropdown list
        public SelectList CategoryTypes { get; set; }

        public IActionResult OnGet()
        {
        ViewData["ParentId"] = new SelectList(_context.OfitCategory, "Id", "Name");
        ViewData["CompanyId"] = new SelectList(_context.OfitCompany, "Id", "Name");
        CategoryTypes = new SelectList(Enum.GetValues(typeof(CategoryType1)));
        IsChecked = true; // Mặc định là true
            return Page();
        }

        [BindProperty]
        public OfitCategory OfitCategory { get; set; } = default!;
        public OfitCompany OfitCompany { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                OnGet();
                return Page(); // Quay lại form để hiển thị lỗi

            }

            // Check trùng lặp tên
            if (await _validateData.CheckDuplicateNameAsync<OfitCategory>(OfitCategory.Name, OfitCategory.Id))
            {
                // Thêm thông báo lỗi cho người dùng
                ModelState.AddModelError("OfitCategory.Name", "Category name already exists.");
                OnGet();
                return Page(); // Quay lại form để hiển thị lỗi
            }

            //Từ động tăng 
            OfitCategory.Sequence = await _validateData.GetNextSequenceAsync<OfitCategory>();

            _context.OfitCategory.Add(OfitCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
