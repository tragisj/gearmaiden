using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FNSB.File.Viewer.Models;

namespace FNSB.File.Viewer.Pages.GearItem
{
    public class DeleteModel : PageModel
    {
        private readonly FNSB.File.Viewer.Models.GearContext _context;

        public DeleteModel(FNSB.File.Viewer.Models.GearContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.GearItem GearItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GearItem = await _context.GearItems.FirstOrDefaultAsync(m => m.GearItemId == id);

            if (GearItem == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GearItem = await _context.GearItems.FindAsync(id);

            if (GearItem != null)
            {
                _context.GearItems.Remove(GearItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
