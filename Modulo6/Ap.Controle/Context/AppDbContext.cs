using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap.Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap.Controle.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Condominio> Condominios {get; set;}
    public DbSet<Morador> Moradores {get; set;}
}
