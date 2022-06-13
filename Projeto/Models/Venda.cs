using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Projeto.Models

{
    [Table("Venda")]
    public class Venda
    {
        [Column("IdVenda")]
        [Display(Name = "IdVenda")]
        public int Id { get; set; }

        [Column("IdCliente")]
        [Display(Name = "Id do Cliente")]
        public string Clientes { get; set; }

        [Column("IdProduto")]
        [Display(Name = "Id do Produto")]
        public string Produto { get; set; }

        [Column("qtdVenda")]
        [Display(Name = "Quantidade")]
        public string Quantidade { get; set; }

        [Column("VlrUnitario")]
        [Display(Name = "Valor Unitario")]
        public string Unitario { get; set; }


        [Column("dthVenda")]
        [Display(Name = "Data da Venda")]
        public string Data { get; set; }

        [Column("VlrTotalVenda")]
        [Display(Name = "Valor Total da Venda")]

        public string ValorTotal { get; set; }
        public int IdProduto { get; internal set; }
        public string NomeProduto { get; internal set; }
    }
}
