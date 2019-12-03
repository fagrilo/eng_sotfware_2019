using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Aluno : Pessoa
    {
        public void Perguntar(string pergunta)
        {
            Duvida duvida = new Duvida
            {
                Enunciado = pergunta
            };

        }
    }
}
