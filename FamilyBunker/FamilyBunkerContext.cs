using FamilyBunker.Entities;
using FamilyBunker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker
{
    //public class FamilyBunkerContext : DbContext
    public class FamilyBunkerContext : IdentityDbContext<ApplicationUser>
    {
        public FamilyBunkerContext(DbContextOptions<FamilyBunkerContext> options)
            : base (options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<groceryList> groceryLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"");
    }
}
