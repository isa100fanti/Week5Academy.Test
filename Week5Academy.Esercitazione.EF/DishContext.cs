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
            modelBuilder.Entity<Dish>().HasKey(k => k.Id);
            modelBuilder.Entity<Dish>().Property(a => a.Name).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Dish>().Property(d => d.Description).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Dish>().Property(p => p.Price).IsRequired();
            modelBuilder.Entity<Dish>().Property(t => t.TypeCourse).IsRequired();
            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "pasta al sugo", Description = "pasta al pomodoro con basilico", Price = 8, TypeCourse = TypeCourse.MainCourse },
                new Dish { Id = 2, Name = " hamburger", Description = "hamburger con cheddar e insalata", Price = 10.3, TypeCourse = TypeCourse.SecondCourse },
                new Dish { Id = 3, Name = " patatine fritte", Description = "patatine con salse", Price = 4.3, TypeCourse = TypeCourse.Sides },
                new Dish { Id = 4, Name = " lasagne al forno", Description = "lasagne al ragu", Price = 8, TypeCourse = TypeCourse.MainCourse },
                new Dish { Id = 5, Name = " Tiramisu", Description = "tiramisu al caffe della casa", Price = 5.2, TypeCourse = TypeCourse.Dessert },
                new Dish { Id = 6, Name = " hamburger con bacon", Description = "hamburger con cheddar bacon e insalata", Price = 12.3, TypeCourse = TypeCourse.SecondCourse }
                //new Dish { Id = 7, Name = " hamburger", Description = "hamburger con cheddar e insalata", Price = 10.3, TypeCourse = TypeCourse.SecondCourse }
                );

            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Account>().HasKey(k => k.Id);
            modelBuilder.Entity<Account>().Property(u => u.Username).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Account>().Property(p => p.Password).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Account>().Property(a => a.Role).IsRequired();
            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, Username = "ginos@venice.it", Password = "1234", Role = Role.Owner },
                new Account { Id = 2, Username = "isacento@vabc.it", Password = "5678", Role = Role.Client }
                );
        }

    }
}
