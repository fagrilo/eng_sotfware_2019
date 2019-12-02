using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Pessoa
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private List<int> Notas { get; set; }
        private double Avaliacao { get; set; }

        public Pessoa Mostrar(int Id)
        {
            Pessoa pessoa = DAOPessoa.Read(Id);
            return pessoa;
        }

        public void Avaliar(int NotaAval, Pessoa pessoa)
        {
            pessoa.Notas.Add(NotaAval);
            Avaliacao = Notas.Average();
        }

    }
}
