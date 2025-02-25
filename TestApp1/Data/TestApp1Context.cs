using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp1.Models;

namespace TestApp1.Data
{
    public class TestApp1Context : DbContext
    {
        public TestApp1Context (DbContextOptions<TestApp1Context> options)
            : base(options)
        {
        }

        public DbSet<TestApp1.Models.TeamListing> TeamListing { get; set; } = default!;
    }
}
