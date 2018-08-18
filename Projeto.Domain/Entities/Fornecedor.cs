using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
    }

    public class Fornecedor : Pessoa
    {
        public List<Cliente> Clientes { get; set; }
        public List<Fabricante> Fabricantes { get; set; }
        public List<Material> MaterialFornecido { get; set; }
        public List<MateriaPrima> MateriasPrimas { get; set; }
    }

    public class Fabricante : Pessoa
    {

    }

    public class Cliente : Pessoa
    {
    }

    public class Material
    {
        public virtual List<MateriaPrima> MateriaPrimaList { get; set; }
    }

    public class Servico
    {

    }

    public class MateriaPrima
    {
    }
}
