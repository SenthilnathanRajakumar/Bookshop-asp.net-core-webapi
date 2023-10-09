using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop_WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop_WebApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>()
              .HasOne(b => b.Author)
              .WithMany(ba => ba.Book_Authors)
              .HasForeignKey(bi => bi.AuthorId);

            modelBuilder.Entity<Log>().HasKey(n => n.Id);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Log> Logs { get; set; }
        //public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
