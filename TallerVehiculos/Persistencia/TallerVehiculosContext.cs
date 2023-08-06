using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;


public class TallerVehiculosContext : DbContext
{
    public TallerVehiculosContext(DbContextOptions<TallerVehiculosContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}