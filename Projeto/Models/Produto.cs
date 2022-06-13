using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Models

{
    [Table("Produto")]

    public class Produto
    
         {
        [Column("IdProduto")]
        [Display(Name = "Código")]
        public int Id { get; set; }




        [Column]
        [Display(Name = "Valor")]
        public float vlrUnitario { get; set; }

       
    }

}
