using Sistemas.DoacaoDeSangue.ColetaAPI.Repositorys;
using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.ColetaAPI.Controllers
{
    public class ServicosPrestadoController : ApiController
    {
        ServicosPrestadosRepository repository = new ServicosPrestadosRepository();

        [HttpPost]
        public HttpResponseMessage CriarServicosPrestado(List<ServicosPrestados> servicosPrestados)
        {
            string retorno = repository.Add(servicosPrestados);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;

        }
        
    }
}
