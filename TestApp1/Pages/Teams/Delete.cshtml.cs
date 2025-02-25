using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestApp1.Data;
using TestApp1.Models;

namespace TestApp1.Pages.Teams
{
    public class DeleteModel : PageModel
    {
        private readonly TestApp1.Data.TestApp1Context _context;

        public DeleteModel(TestApp1.Data.TestApp1Context context)
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

            var teamlisting = await _context.TeamListing.FirstOrDefaultAsync(m => m.Id == id);

            if (teamlisting is not null)
            {
                TeamListing = teamlisting;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamlisting = await _context.TeamListing.FindAsync(id);
            if (teamlisting != null)
            {
                TeamListing = teamlisting;
                _context.TeamListing.Remove(TeamListing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
