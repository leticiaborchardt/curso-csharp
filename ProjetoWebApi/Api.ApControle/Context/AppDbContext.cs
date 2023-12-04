using Api.ApControle.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.ApControle.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Condominio> Condominios {get; set;}
    public DbSet<Morador> Moradores {get; set;}
}