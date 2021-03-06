﻿using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels.Produtos
{
    public class ProdutoEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o Id do Produto.")]
        public int IdProduto { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o Nome do Produto.")]
        public string Nome { get; set; }

        [Range(0.01, 999999, ErrorMessage = "Informe um valor entre {1} e {2}")]
        [Required(ErrorMessage = "Informe o Preço do Produto.")]
        public decimal Preco { get; set; }

        [Range(1, 99999, ErrorMessage = "Informe um valor entre {1} e {2}")]
        [Required(ErrorMessage = "Informe a Quantidade do Produto.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o Estoque do Produto.")]
        public int IdEstoque { get; set; }
    }
}
