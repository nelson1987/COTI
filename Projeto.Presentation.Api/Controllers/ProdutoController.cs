﻿using Projeto.Application.Contracts;
using Projeto.Application.ViewModels.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(ProdutoEdicaoViewModel model)
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
