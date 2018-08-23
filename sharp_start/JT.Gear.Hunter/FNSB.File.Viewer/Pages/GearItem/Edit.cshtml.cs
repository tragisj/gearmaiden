using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FNSB.File.Viewer.Models;

namespace FNSB.File.Viewer.Pages.GearItem
{
    public class EditModel : PageModel
    {
        private readonly FNSB.File.Viewer.Models.GearContext _context;

        public EditModel(FNSB.File.Viewer.Models.GearContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GearItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GearItemExists(GearItem.GearItemId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GearItemExists(int id)
        {
            return _context.GearItems.Any(e => e.GearItemId == id);
        }
    }
}
