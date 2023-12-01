using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConcessionariaZils.Models;

namespace ConcessionariaZils.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Carro> Carros { get; set; }
    public DbSet<Moto> Motos { get; set; }
}