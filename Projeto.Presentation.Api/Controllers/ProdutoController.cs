using Projeto.Application.Contracts;
using Projeto.Application.ViewModels.Produtos;
using Projeto.Presentation.Api.Util;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Presentation.Api.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        //atributo..
        private readonly IProdutoAppService appService;

        //construtor para injeção de dependência
        public ProdutoController(IProdutoAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ProdutoCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Cadastrar(model);
                    //200 - Sucesso - OK
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    //500 - Erro de Aplicação - Internal Server Error
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }
            //400 - Requisição inválida - Bad Request
            return Request.CreateResponse(HttpStatusCode.BadRequest, ValidationUtil.GetErrorMessages(ModelState));
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(ProdutoEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Atualizar(model);
                    //200 - Sucesso - OK
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    //500 - Erro de Aplicação - Internal Server Error
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }
            //400 - Requisição inválida - Bad Request
            return Request.CreateResponse(HttpStatusCode.BadRequest, ValidationUtil.GetErrorMessages(ModelState));
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var produto = appService.ConsultarPorId(id);

                if (produto == null)
                    //Não encontrado
                    return Request.CreateResponse(HttpStatusCode.NotFound);

                appService.Excluir(id);

                //200 - Sucesso - OK
                return Request.CreateResponse(HttpStatusCode.OK, produto);
            }
            catch (Exception ex)
            {
                //500 - Erro de Aplicação - Internal Server Error
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, appService.ConsultarTodos());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("obter")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var produto = appService.ConsultarPorId(id);

                if (produto == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound);

                return Request.CreateResponse(HttpStatusCode.OK, produto);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
