using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap.Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap.Controle.Context;

public class AppDbContext : DbContext
{
    // public AppDbContext(DbContextOptionsBuilder options) : base(options)
    // {

    // }

    public DbSet<Condominio> Condominios;
    public DbSet<Morador> Moradores;
}
