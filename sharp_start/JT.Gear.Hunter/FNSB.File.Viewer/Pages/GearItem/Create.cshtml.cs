using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FNSB.File.Viewer.Models;

namespace FNSB.File.Viewer.Pages.GearItem
{
    public class CreateModel : PageModel
    {
        private readonly FNSB.File.Viewer.Models.GearContext _context;

        public CreateModel(FNSB.File.Viewer.Models.GearContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.GearItem GearItem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GearItems.Add(GearItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}