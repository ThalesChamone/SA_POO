using SA_OOP.Data;
using SA_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Repositories
{
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly SA_OOPContext _context;

        public ProcedimentoRepository(SA_OOPContext context)
        {
            _context = context;
        }
        public IEnumerable<Procedimento> Procedimentos => _context.Procedimentos;

        public Procedimento GetProcedimentoById(int Id)
        {
            return _context.Procedimentos.FirstOrDefault(p => p.Codigo == Id);
        }
    }
}
