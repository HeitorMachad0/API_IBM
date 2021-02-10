using IBM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBM.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Contrato> Contratos { get; set; }

        public DbSet<Prestacao> Prestacoes { get; set; }
    }
}
