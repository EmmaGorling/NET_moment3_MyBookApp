using Microsoft.EntityFrameworkCore;
using MyBookApp.Models;

namespace MyBookApp.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
}