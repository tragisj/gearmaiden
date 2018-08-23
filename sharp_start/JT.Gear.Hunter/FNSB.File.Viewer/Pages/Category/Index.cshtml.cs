using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FNSB.File.Viewer.Models;

namespace FNSB.File.Viewer.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly FNSB.File.Viewer.Models.GearContext _context;

        public IndexModel(FNSB.File.Viewer.Models.GearContext context)
        {
            _context = context;
        }

        public IList<Models.Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
