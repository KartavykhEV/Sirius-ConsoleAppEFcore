using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFcore
{
    internal class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Сотрудники
        /// </summary>
        public DbSet<person> persons { get; set; }  
        public DbSet<gender> genders { get; set; }


        public DbSet<book> books { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<book_category> book_categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<book_category>().
                HasKey(i => new { i.BookId, i.CategoryId });
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=efcore;Username=efuser;Password=123456");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}
