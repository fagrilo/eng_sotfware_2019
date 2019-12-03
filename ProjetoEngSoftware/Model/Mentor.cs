using System;
using System.Collections.Generic;
using ProjetoEngSoftware.DAO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Mentor
    {
        private int Id { get; set; }
        private List<Disciplina> Disciplinas { get; set; }

        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
            MentorDAO.Update();
        }

        public void Avaliar(int Nota, Pessoa pessoa)
        {
            pessoa.Avaliar(Nota, pessoa);
        }

    }
}
