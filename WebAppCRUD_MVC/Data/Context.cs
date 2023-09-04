using Microsoft.EntityFrameworkCore;
using WebAppCRUD_MVC.Models;

namespace WebAppCRUD_MVC.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options)
            : base(options)
    { }

    public DbSet<User> User { get; set; }
}
