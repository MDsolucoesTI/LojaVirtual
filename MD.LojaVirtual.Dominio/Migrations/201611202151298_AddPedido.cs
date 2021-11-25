//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

namespace MD.LojaVirtual.Dominio.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AddPedido : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.Pedido",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            ClienteId = c.String(maxLength: 128),
            EmbrulhaPresente = c.Boolean(nullable: false),
            Pago = c.Boolean(nullable: false),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.AspNetUsers", t => t.ClienteId)
          .Index(t => t.ClienteId);

      CreateTable(
          "dbo.ProdutoPedido",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            PedidoId = c.Int(nullable: false),
            ProdutoId = c.Int(nullable: false),
            Quantidade = c.Int(nullable: false),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Pedido", t => t.PedidoId, cascadeDelete: true)
          .ForeignKey("dbo.MDProduto", t => t.ProdutoId, cascadeDelete: true)
          .Index(t => t.PedidoId)
          .Index(t => t.ProdutoId);

      AddColumn("dbo.AspNetUsers", "NomeCompleto", c => c.String(nullable: false));
    }

    public override void Down()
    {
      DropForeignKey("dbo.ProdutoPedido", "ProdutoId", "dbo.MDProduto");
      DropForeignKey("dbo.ProdutoPedido", "PedidoId", "dbo.Pedido");
      DropForeignKey("dbo.Pedido", "ClienteId", "dbo.AspNetUsers");
      DropIndex("dbo.ProdutoPedido", new[] { "ProdutoId" });
      DropIndex("dbo.ProdutoPedido", new[] { "PedidoId" });
      DropIndex("dbo.Pedido", new[] { "ClienteId" });
      DropColumn("dbo.AspNetUsers", "NomeCompleto");
      DropTable("dbo.ProdutoPedido");
      DropTable("dbo.Pedido");
    }
  }
}
