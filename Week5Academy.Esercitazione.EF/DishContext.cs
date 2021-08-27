using Microsoft.EntityFrameworkCore;
using System;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.EF
{
    public class DishContext : DbContext
    {
        public DbSet<Dish> Dishes {get;set;}
        public DbSet<Account> Accounts {get;set;}

        public DishContext(DbContextOptions<DishContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().ToTable("Dish");
        }

    }
}
