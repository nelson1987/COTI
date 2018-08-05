using Projeto.Application.Contracts;
using Projeto.Application.ViewModels.Estoques;
using System;
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
            try
            {
                appService.Cadastrar(model);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(EstoqueEdicaoViewModel model)
        {
            try
            {
                appService.Atualizar(model);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                appService.Excluir(id);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                appService.ConsultarTodos();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("obter")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                appService.ConsultarPorId(id);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
