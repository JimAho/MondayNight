using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestApp1.Data;
using TestApp1.Models;

namespace TestApp1.Pages.Teams
{
    public class EditModel : PageModel
    {
        private readonly TestApp1.Data.TestApp1Context _context;

        public EditModel(TestApp1.Data.TestApp1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TeamListing TeamListing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamlisting =  await _context.TeamListing.FirstOrDefaultAsync(m => m.Id == id);
            if (teamlisting == null)
            {
                return NotFound();
            }
            TeamListing = teamlisting;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TeamListing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamListingExists(TeamListing.Id))
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

        private bool TeamListingExists(int id)
        {
            return _context.TeamListing.Any(e => e.Id == id);
        }
    }
}
