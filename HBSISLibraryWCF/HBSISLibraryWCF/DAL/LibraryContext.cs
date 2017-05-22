using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("LibraryContext")
        {
        }

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<PublisherEntity> Publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<BookEntity>()
                .HasMany<AuthorEntity>(s => s.Authors)
                .WithMany(c => c.Books)
                .Map(cs =>
                {
                    cs.MapLeftKey("BookId");
                    cs.MapRightKey("AuthorId");
                    cs.ToTable("BookAuthor");
                });
        }
    }
}