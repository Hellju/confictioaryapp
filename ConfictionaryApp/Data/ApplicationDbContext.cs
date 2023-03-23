using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ConfictionaryApp.Models;

namespace ConfictionaryApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ConfictionaryApp.Models.Customer> Customer { get; set; }
        public DbSet<ConfictionaryApp.Models.Product> Product { get; set; }
        public DbSet<ConfictionaryApp.Models.Order> Order { get; set; }
        public DbSet<ConfictionaryApp.Models.OrderDetail> OrderDetail { get; set; }
    }
}
