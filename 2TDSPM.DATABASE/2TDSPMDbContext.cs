using _2TDSPM.Models;
using Microsoft.EntityFrameworkCore;

namespace _2TDSPM.DATABASE;
public class _2TDSPMDbContext(DbContextOptions<_2TDSPMDbContext> options) : DbContext(options)
{
  public DbSet<User> Users{ get; set; }

}
