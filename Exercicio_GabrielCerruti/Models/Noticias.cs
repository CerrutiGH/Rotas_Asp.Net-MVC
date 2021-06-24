using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_GabrielCerruti.Models
{
    public class Noticias
    {
        public int COD_NOTICIA { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Título da notícia")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Insira informação de 5 até 100 caracteres")]
        public string TITULO_NOTICIA { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Descrição da matéria")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Insira informação de 5 até 100 caracteres")]
        public string DESCRICAO_NOTICIA { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Categoria da notícia")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Insira informação de 5 até 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Somente letras, no mínimo 5 e máximo 100 caracteres")]
        public string CATEGORIA_NOTICIA { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data da matéria")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DATA_NOTICIA { get; set; }
    }
}