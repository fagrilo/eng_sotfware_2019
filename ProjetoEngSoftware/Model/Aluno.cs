using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Aluno
    {
        public void Perguntar()
        {
            
        }
        public void Avaliar(int Nota, Pessoa pessoa)
        {
            pessoa.Avaliar(Nota, pessoa);
        }
    }
}
