using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;

namespace Sistemas.DoacaoDeSangue.Log
{
    public class Logar
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        public void CriaLog(ObjetoLog objetoLog)
        {
            entities.CriarLog(objetoLog.TipoLog, objetoLog.Mensagem);
        }
    }
}
