using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bookstore.DBC;
public class DataContext : DbContext
{
    public DataContext() : base()
    {
    }
    public DbSet<Publishers> Publishers { get; set; }
    public DbSet<Sections> Sections { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<Сustomer> Сustomer { get; set; }
    public DbSet<Suppliers> Suppliers { get; set; }
    public DbSet<Books> Books { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseMySql("server=localhost;user=root;password=root;database=bookstore",
            new MySqlServerVersion(new Version(10, 6, 0)));
    }
}
