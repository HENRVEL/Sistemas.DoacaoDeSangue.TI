using Sistemas.DoacaoDeSangue.AgendamentoAPI.Repositorys;
using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Controllers
{
    public class AgendaLaboratorioController : ApiController
    {
        AgendaLaboratorioRepository repository = new AgendaLaboratorioRepository();


        [HttpGet]
        public IEnumerable<AgendaLaboratorio> ObterAgendaLaboratorio(int id)
        {
            IEnumerable<AgendaLaboratorio> listaAgendaLaboratorio;

            listaAgendaLaboratorio = repository.Get(id);

            if (listaAgendaLaboratorio == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return listaAgendaLaboratorio;
        }
    }
}
