using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using TestApp1.Data;
using TestApp1.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp1.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly TestApp1.Data.TestApp1Context _context;
        public string? TeamMascot;


        public IndexModel(TestApp1.Data.TestApp1Context context)
        {
            _context = context;
        }

        public IList<TeamListing> TeamListing { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public string? TeamRank;
        public string selectedName;
       
        public SelectList? Teams { get; set; }

        [BindProperty(SupportsGet = true)]
        public string TeamSearch { get; set; }
        public string? DropdownList { get; set; }
        
        public async Task OnGetAsync(string dropdownSelector)
        {
            
            var teamlist = from m in _context.TeamListing
                           select m;

            Console.WriteLine("The Dropdown Selector Is " + dropdownSelector);

            
            /* if (!string.IsNullOrEmpty(SearchString))
            {
                teamlist = teamlist.Where(s => s.Team.Contains(SearchString) || s.Mascot.Contains(SearchString) || s.DateOfLastWin.Contains(SearchString));
                Console.WriteLine(dropdownSelector);
            } */

            if (string.IsNullOrEmpty(dropdownSelector))
            {
                dropdownSelector = "AllColumns";
                Console.WriteLine("The Dropdown Selector Was " + dropdownSelector); 

            }

            if (dropdownSelector.Equals("Team"))
            {
                teamlist = teamlist.Where(s => s.Team.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Rank"))
            {
                teamlist = teamlist.Where(s => s.Rank.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Mascot"))
            {
                teamlist = teamlist.Where(s => s.Mascot.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("DateOfLastWin"))
            {
                teamlist = teamlist.Where(s => s.DateOfLastWin.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("WinningPercentage"))
            {
                teamlist = teamlist.Where(s => s.WinningPercentage.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Wins"))
            {
                teamlist = teamlist.Where(s => s.Wins.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Losses"))
            {
                teamlist = teamlist.Where(s => s.Losses.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Ties"))
            {
                teamlist = teamlist.Where(s => s.Ties.Contains(SearchString));
            }
            else if (dropdownSelector.Equals("Games"))
            {
                teamlist = teamlist.Where(s => s.Games.Contains(SearchString));
            }
            else
            {
                teamlist = teamlist.Where(s => s.Rank.Contains(SearchString) || s.Team.Contains(SearchString) || s.Mascot.Contains(SearchString) || s.DateOfLastWin.Contains(SearchString) || s.WinningPercentage.Contains(SearchString) || s.Wins.Contains(SearchString) || s.Losses.Contains(SearchString) || s.Ties.Contains(SearchString) || s.Games.Contains(SearchString));
            }


            TeamListing = await teamlist.ToListAsync();
        } 
        /* public async Task OnGetAsync()
        {
            TeamListing = await _context.TeamListing.ToListAsync();
        } */
        }




    }
    

 

    



    
