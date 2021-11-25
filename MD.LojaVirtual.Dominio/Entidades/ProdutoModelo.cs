﻿//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

namespace MD.LojaVirtual.Dominio.Entidades
{

  public class ProdutoModelo
  {
    public int ProdutoModeloId { get; set; }
    public string ProdutoModeloCodigo { get; set; }
    public string ProdutoDescricao { get; set; }
    public string UnidadeVenda { get; set; }
    public string GrupoCodigo { get; set; }
    public string SubGrupoCodigo { get; set; }
    public string CategoriaCodigo { get; set; }
    public string MarcaCodigo { get; set; }
    public string GeneroCodigo { get; set; }
    public string FaixaEtariaCodigo { get; set; }
    public string ModalidadeCodigo { get; set; }
    public string LinhaCodigo { get; set; }
    public string MarcaDescricao { get; set; }
    public string DescricaoResumida { get; set; }
  }
}

