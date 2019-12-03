using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Aluno
    {
        public void Perguntar(string pergunta)
        {
            Duvida duvida = new Duvida();
            duvida.Enunciado = pergunta;

        }

        public void Avaliar(int Nota, Pessoa pessoa)
        {
            pessoa.Avaliar(Nota, pessoa);
        }
    }
}
