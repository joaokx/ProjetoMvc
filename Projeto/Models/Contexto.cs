using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
   
{
    public class Contexto : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Contexto(DbContextOptions<Contexto> options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Projeto.Models.Clientes>? Clientes { get; set; }
        public DbSet<Projeto.Models.Venda1>? Venda1 { get; set; }


       
                
    }
}
