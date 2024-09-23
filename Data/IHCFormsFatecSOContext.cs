using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IHCFormsFatecSO.Models;

namespace IHCFormsFatecSO.Data
{
    public class IHCFormsFatecSOContext : DbContext
    {
        public IHCFormsFatecSOContext (DbContextOptions<IHCFormsFatecSOContext> options)
            : base(options)
        {
        }

        public DbSet<IHCFormsFatecSO.Models.Denuncia> Denuncia { get; set; } = default!;

        public DbSet<IHCFormsFatecSO.Models.Denuncia> Estabelecimento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estabelecimento>()
                .HasKey(
                p => new { p.CnpjBasico, p.CnpjOrdem, p.CnpjDv });
        }
    }
}
