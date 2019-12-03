using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEngSoftware.DAO;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class SalvarDuvida : IAcoesDuvida
    {
        public void Execute(Duvida duvida)
        {
            DuvidaDAO.Create(duvida);
        }
    }
}
