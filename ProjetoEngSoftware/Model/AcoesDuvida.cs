using ProjetoEngSoftware.DAO;
using System.Linq;

namespace ProjetoEngSoftware.Model
{
    public class AcoesDuvida
    {
        public void Action(Duvida duvida)
        {
            Notificacao Noti = new Notificacao();
            Noti.CreateNotificacao(duvida.ListaDisciplina.FirstOrDefault());


            DuvidaDAO Create = new DuvidaDAO();
            DuvidaDAO.Create(duvida);

        }
    }
}
