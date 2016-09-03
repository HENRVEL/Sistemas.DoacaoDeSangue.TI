using Sistemas.DoacaoDeSangue.SegurancaAPI.Respositorys;
using Sistemas.DoacaoDeSangue.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.SegurancaAPI.Controllers
{
    public class SegurancaController : ApiController
    {
        SegurancaRepository repository = new SegurancaRepository();

        [HttpGet]
        public HttpResponseMessage VerificarSenhaUsuario(string usuario, string tipoUsuario, string senha)
        {
            string retorno = repository.Get(usuario, tipoUsuario, senha);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

        [HttpPost]
        public HttpResponseMessage CriarUsuario(Seguranca Seguranca)
        {
            string retorno = repository.Add(Seguranca);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }


    }
}
