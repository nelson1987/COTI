using Projeto.Application.ViewModels.Produtos;
using System.Collections.Generic;

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
