using Projeto.Application.ViewModels.Estoques;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IEstoqueAppService
    {
        void Cadastrar(EstoqueCadastroViewModel model);

        void Atualizar(EstoqueEdicaoViewModel model);

        void Excluir(int idEstoque);

        List<EstoqueConsultaViewModel> ConsultarTodos();

        EstoqueConsultaViewModel ConsultarPorId(int idEstoque);
    }
}
