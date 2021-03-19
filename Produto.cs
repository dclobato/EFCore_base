using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Linq1
{
  public class Produto
  {
    public int ProdutoID { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoProduto { get; set; }
    public int EstoqueProduto { get; set; }
  }

  public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
  {
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
      builder.Property(t => t.NomeProduto).IsRequired().HasMaxLength(80);
      builder.Property(t => t.EstoqueProduto).HasDefaultValue(0);
      builder.Property(t => t.PrecoProduto).HasPrecision(10, 2);
    }
  }

  public static class ModelBuilderExtensions
  {
    public static void SeedDatabase(this ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 1,
        NomeProduto = "Leite Condensado Moça 395g",
        PrecoProduto = 5.89M,
        EstoqueProduto = 100
      });
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 2,
        NomeProduto = "Iogurte Sabor Mel Natural Batavo 170g",
        PrecoProduto = 1.80M,
        EstoqueProduto = 80
      });
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 3,
        NomeProduto = "Queijo Parmesão Ralado President 50g",
        PrecoProduto = 3.59M,
        EstoqueProduto = 43
      });
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 4,
        NomeProduto = "Biscoito Recheado Original Oreo 144g",
        PrecoProduto = 4.89M,
        EstoqueProduto = 56
      });
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 5,
        NomeProduto = "Bombom Sonho de Valsa Lacta 1Kg",
        PrecoProduto = 34.09M,
        EstoqueProduto = 20
      });
      modelBuilder.Entity<Produto>().HasData(new Produto
      {
        ProdutoID = 6,
        NomeProduto = "Lava Roupas Líquido Omo Lavagem Perfeita 5L",
        PrecoProduto = 48.29M,
        EstoqueProduto = 10
      });
    }
  }


}
