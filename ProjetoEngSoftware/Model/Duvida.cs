using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEngSoftware.Model
{
    public class Duvida : IResponderDuvida, IPerguntaDuvida
    {
        public int Id { get; set; }
        public List<Disciplina> ListaDisciplina { get; set; }

        public void Perguntar()
        {
            throw new NotImplementedException();
        }

        public void ReceberDuvida()
        {

        }

        public void Responder(Duvida duvida)
        {
            throw new NotImplementedException();
        }
    }
}
