#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorpagesJoshua.Data;
using RazorpagesJoshua.Models;

namespace RazorpagesJoshua.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorpagesJoshua.Data.RazorpagesJoshuaContext _context;

        public DetailsModel(RazorpagesJoshua.Data.RazorpagesJoshuaContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
