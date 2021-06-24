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
        public string TITULO_NOTICIA { get; set; }
        public string DESCRICAO_NOTICIA { get; set; }
        public string CATEGORIA_NOTICIA { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DATA_NOTICIA { get; set; }
    }
}