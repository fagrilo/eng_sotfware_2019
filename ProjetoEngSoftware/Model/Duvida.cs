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
        public List<IAcoesDuvida> ListaAcoes;
        public Duvida(List<IAcoesDuvida> acoes)
        {
            ListaAcoes = acoes;
        }
        public void Perguntar()
        {

        }

        public void ReceberDuvida(Duvida duvida)
        {
            foreach(IAcoesDuvida acoes in ListaAcoes)
            {
                acoes.Execute(duvida);
            }
        }

        public void Responder(Duvida duvida)
        {
            
        }
    }
}
