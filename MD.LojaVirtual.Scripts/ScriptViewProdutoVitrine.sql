/*////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
////////////////////////////////////////////////////////////////////////*/

USE [MD]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ProdutoVitrine]
AS
SELECT DISTINCT 
                         MIN(LEFT(dbo.Produto.ProdutoCodigo, 8)) AS ProdutoModeloCor, dbo.Produto.ProdutoDescricao, dbo.Produto.MarcaDescricao, dbo.Produto.Preco, dbo.ProdutoModelo.GrupoCodigo, 
                         dbo.ProdutoModelo.SubGrupoCodigo, dbo.ProdutoModelo.CategoriaCodigo, dbo.ProdutoModelo.MarcaCodigo, dbo.ProdutoModelo.GeneroCodigo, dbo.ProdutoModelo.FaixaEtariaCodigo, 
                         dbo.ProdutoModelo.ModalidadeCodigo, dbo.ProdutoModelo.LinhaCodigo
FROM            dbo.ProdutoModelo INNER JOIN
                         dbo.Produto ON dbo.ProdutoModelo.ProdutoModeloCodigo = dbo.Produto.ProdutoModeloCodigo
GROUP BY dbo.Produto.ProdutoDescricao, dbo.Produto.MarcaDescricao, dbo.Produto.Preco, dbo.ProdutoModelo.GrupoCodigo, dbo.ProdutoModelo.SubGrupoCodigo, dbo.ProdutoModelo.CategoriaCodigo, 
                         dbo.ProdutoModelo.MarcaCodigo, dbo.ProdutoModelo.GeneroCodigo, dbo.ProdutoModelo.FaixaEtariaCodigo, dbo.ProdutoModelo.ModalidadeCodigo, dbo.ProdutoModelo.LinhaCodigo

GO