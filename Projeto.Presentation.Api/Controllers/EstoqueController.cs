using Projeto.Application.Contracts;
using Projeto.Application.ViewModels.Estoques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Presentation.Api.Controllers
{
    [RoutePrefix("api/estoque")]
    public class EstoqueController : ApiController
    {
        //atributo..
        private readonly IEstoqueAppService appService;

        //construtor para o simple injector..
        public EstoqueController(IEstoqueAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(EstoqueCadastroViewModel model)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(EstoqueEdicaoViewModel model)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("obter")]
        public HttpResponseMessage GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
