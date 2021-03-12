using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name="Descrição")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}