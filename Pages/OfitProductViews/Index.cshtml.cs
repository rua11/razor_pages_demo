﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Pages.OfitProductViews
{
    public class IndexModel : PageModel
    {
        private readonly razor_demo.Data.AppDbContext _context;

        public IndexModel(razor_demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<OfitProduct> OfitProduct { get;set; } = default!;

        public async Task OnGetAsync()
        {
            OfitProduct = await _context.OfitProduct
                .Include(o => o.OfitCategory).ToListAsync();
        }
    }
}
