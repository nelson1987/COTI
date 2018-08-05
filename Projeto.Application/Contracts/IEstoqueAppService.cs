using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels.Estoques;

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
