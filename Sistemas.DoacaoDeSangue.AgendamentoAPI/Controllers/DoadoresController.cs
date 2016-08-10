using Sistemas.DoacaoDeSangue.AgendamentoAPI.Repository;
using Sistemas.DoacaoDeSangue.DTO;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Controllers
{
    public class DoadoresController : ApiController
    {
        DoadorRepository repository = new DoadorRepository();

        [HttpGet]
        public Doador obterDoadorPorId(int id)
        {

            Doador item = repository.GetID(id);
            if (item.Id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpGet]
        public Doador obterDoadorPorCPF(long cpf)
        {
            Doador item = repository.GetCPF(cpf);
            if (item.Id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        public HttpResponseMessage CriarDoador(Doador doador)
        {
            string retorno = repository.Add(doador);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage ExcluirDoador(int id)
        {
            Doador item = repository.GetID(id);

            if (item.Id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                string retorno = repository.Remove(id);
                var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
                return response;

            }
        }

        [HttpPut]
        public HttpResponseMessage AlterarDoador(Doador doador)
        {
            string retorno = repository.Update(doador);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;

        }

    }
}
