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
    public class IndexModel : PageModel
    {
        private readonly RazorpagesJoshua.Data.RazorpagesJoshuaContext _context;

        public IndexModel(RazorpagesJoshua.Data.RazorpagesJoshuaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
