#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorpagesJoshua.Models;

namespace RazorpagesJoshua.Data
{
    public class RazorpagesJoshuaContext : DbContext
    {
        public RazorpagesJoshuaContext (DbContextOptions<RazorpagesJoshuaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorpagesJoshua.Models.Movie> Movie { get; set; }
    }
}
