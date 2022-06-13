using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Models
{
   
        public class Clientes
        {
            [Column("IdCliente")]
            [Display(Name = "IdCliente")]
            public int Id { get; set; }

            [Column("Nome")]
            [Display(Name = "Nome")]
            public string Nome { get; set; }

            [Column("Cidade")]
            [Display(Name = "Cidade")]
            public string Cidade { get; set; }
        }
    }

