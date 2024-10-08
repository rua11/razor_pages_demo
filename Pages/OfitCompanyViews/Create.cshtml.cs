using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_demo.Data;
using razor_demo.DataInitial;
using razor_demo.NewFolder;

namespace razor_demo.Pages.OfitCompanyViews
{
    public class CreateModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;
        private readonly CatagoryData _catagoryData;
        private readonly ValidateData _validateData;


        public CreateModel(razor_demo.Data.AppDbContext context, CatagoryData catagoryData, ValidateData validateData)
        {
            _context = context;
            _catagoryData = catagoryData;
            _validateData = validateData;

        }

        public IActionResult OnGet()
        {
            return Page();
        }
       
        [BindProperty]

        public OfitCompany OfitCompany { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (await _validateData.CheckDuplicateNameAsync<OfitCompany>(OfitCompany.Name, OfitCompany.Id))
            {
                // Thêm thông báo lỗi cho người dùng
                ModelState.AddModelError("OfitCategory.Name", "Category name already exists.");
                OnGet();
                return Page(); // Quay lại form để hiển thị lỗi
            }

            _context.OfitCompany.Add(OfitCompany);
            await _context.SaveChangesAsync();

            await _catagoryData.CreateCategoryAsync<OfitCategory>(OfitCompany.Id);

            return RedirectToPage("./Index");
        }
    }
}
