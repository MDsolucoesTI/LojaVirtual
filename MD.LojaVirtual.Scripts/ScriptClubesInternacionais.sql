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

CREATE VIEW [dbo].[ClubesInternacionais]
AS
SELECT        LinhaCodigo, LinhaDescricao
FROM            dbo.Linha
WHERE        (LinhaCodigo IN (0130, 1388, 0188, 0147, 0016, 0241, 0198, 0124, 0008, 0210, 0779, 1388, 1474))

GO



