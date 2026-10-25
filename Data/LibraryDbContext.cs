using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLibrary.Data
{
    internal class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<BookDetails> BookDetails { get; set; }

        public DbSet <Library> Libraries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=RAZDVA\\SQLExpress; Database=NewLibraryDb; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
