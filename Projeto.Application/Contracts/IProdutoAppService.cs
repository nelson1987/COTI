using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels.Produtos;

namespace Projeto.Application.Contracts
{
    public interface IProdutoAppService
    {
        void Cadastrar(ProdutoCadastroViewModel model);

        void Atualizar(ProdutoEdicaoViewModel model);

        void Excluir(int idProduto);

        List<ProdutoConsultaViewModel> ConsultarTodos();

        ProdutoConsultaViewModel ConsultarPorId(int idProduto);
    }
}
