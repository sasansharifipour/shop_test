using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
