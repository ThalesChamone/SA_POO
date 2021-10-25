using SA_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Repositories
{
    public interface IProcedimentoRepository
    {
        IEnumerable<Procedimento> Procedimentos { get; }
        Procedimento GetProcedimentoById(int Id);
    }
}
