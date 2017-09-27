using BootstrapIntroduction.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BootstrapIntroduction.DAL
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("BookContext")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        protectd override void OnModelCreating(DbModelBuilder modelBuildilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
