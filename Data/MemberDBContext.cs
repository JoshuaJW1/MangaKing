using System;
using System.Collections.Generic;
using System.Text;
using MangaKing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangaKing.Data
{
    public class MemberDbContext : DbContext
    {    // Here we add in all the tables we are using.
        public DbSet<Member> Member { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions

        public MemberDbContext(DbContextOptions<MemberDbContext> options)
            : base(options)
        {
        }

        public MemberDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        { base.OnModelCreating(builder); }

        public DbSet<MangaKing.Models.StaffNames> StaffNames { get; set; }
    }
}
