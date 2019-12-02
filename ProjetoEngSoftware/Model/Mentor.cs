using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Mentor
    {
        List<Disciplina> Disciplinas;

        public void Responder(Duvida duvida)
        {

        }
        public void Avaliar(int Nota, Pessoa pessoa)
        {
            pessoa.Avaliar(Nota, pessoa);
        }

    }
}
