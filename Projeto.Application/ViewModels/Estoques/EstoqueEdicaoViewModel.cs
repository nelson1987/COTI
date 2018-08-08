﻿using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels.Estoques
{
    public class EstoqueEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o Id do Estoque.")]
        public int IdEstoque { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }
    }
}
