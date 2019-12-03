using System;
using System.Collections.Generic;
using ProjetoEngSoftware.DAO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Mentor : Pessoa
    {
        private List<Disciplina> Disciplinas { get; set; }

        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
            MentorDAO.Update(this.Id);
        }

    }
}
