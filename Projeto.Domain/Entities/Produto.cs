using System;

namespace Projeto.Domain.Entities
{
    public class Produto
    {
        public virtual int IdProduto { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual int Quantidade { get; set; }
        protected virtual int IdEstoque { get { return Estoque.IdEstoque; } }
        public virtual DateTime Criacao { get; set; }

        #region Associações

        public virtual Estoque Estoque { get; set; }

        #endregion
    }
}
