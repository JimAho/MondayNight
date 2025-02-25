using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestApp1.Data;
using TestApp1.Models;

namespace TestApp1.Pages.Teams
{
    public class CreateModel : PageModel
    {
        private readonly TestApp1.Data.TestApp1Context _context;

        public CreateModel(TestApp1.Data.TestApp1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TeamListing TeamListing { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TeamListing.Add(TeamListing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
