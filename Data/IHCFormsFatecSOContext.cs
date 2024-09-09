using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Validacao_Form.Models;

namespace IHCFormsFatecSO.Data
{
    public class IHCFormsFatecSOContext : DbContext
    {
        public IHCFormsFatecSOContext (DbContextOptions<IHCFormsFatecSOContext> options)
            : base(options)
        {
        }

        public DbSet<Validacao_Form.Models.Denuncia> Denuncia { get; set; } = default!;
    }
}
