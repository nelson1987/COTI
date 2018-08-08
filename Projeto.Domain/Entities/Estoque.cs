using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    public class Estoque
    {
        public virtual int IdEstoque { get; set; }
        public virtual string Nome { get; set; }

        #region Associações

        public virtual List<Produto> Produtos { get; set; }

        #endregion
    }
}
