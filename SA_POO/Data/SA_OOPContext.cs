using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SA_OOP.Models;

namespace SA_OOP.Data
{
    public class SA_OOPContext : DbContext
    {
        public SA_OOPContext (DbContextOptions<SA_OOPContext> options)
            : base(options)
        {
        }

        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<SA_OOP.Models.Especialidade> Especialidade { get; set; }
        public DbSet<SA_OOP.Models.Paciente> Paciente { get; set; }
        public DbSet<SA_OOP.Models.Convenio> Convenio { get; set; }
        public DbSet<SA_OOP.Models.Medico> Medico { get; set; }
    }
}
