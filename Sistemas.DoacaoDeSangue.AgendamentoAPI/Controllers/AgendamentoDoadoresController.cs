using Sistemas.DoacaoDeSangue.AgendamentoAPI.Repository;
using Sistemas.DoacaoDeSangue.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Controllers
{
    public class AgendamentoDoadoresController : ApiController
    {
        AgendamentoDoadorRepository repository = new AgendamentoDoadorRepository();

        [HttpGet]
        public IEnumerable<AgendamentoDoador> ObterAgendamentoDoador(int id)
        {
            IEnumerable<AgendamentoDoador> listaAgendamentoDoador;

            listaAgendamentoDoador = repository.GetAll(id);

            if (listaAgendamentoDoador == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return listaAgendamentoDoador;
        }

        [HttpPost]
        public HttpResponseMessage CriarAgendamentoDoador(AgendamentoDoador agendamentoDoador)
        {
            string retorno = repository.Add(agendamentoDoador);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

    }
}
