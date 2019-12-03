using System;
using System.Linq;
using ProjetoEngSoftware.DAO;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ProjetoEngSoftware.Model
{
    public class Duvida : IResponderDuvida, IPerguntaDuvida
    {
        private int Id { get; set; }
        public string Enunciado { get; set; }
        public List<Disciplina> ListaDisciplina { get; set; }
        public void Perguntar()
        {

        }

        public void ReceberDuvida(Duvida duvida)
        {
            AcoesDuvida acoes = new AcoesDuvida();
            acoes.Action(duvida);
        }

        public void Responder(Duvida duvida)
        {
            
        }
    }
}
