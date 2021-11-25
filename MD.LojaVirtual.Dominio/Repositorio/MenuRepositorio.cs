//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using FastMapper;
using MD.LojaVirtual.Dominio.Dto;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Dominio.Entidades.Vitrine;

namespace MD.LojaVirtual.Dominio.Repositorio
{
  public class MenuRepositorio
  {
    private readonly EfDbContext _context = new EfDbContext();

    public IEnumerable<Categoria> ObterCategorias()
    {
      return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
    }

    /// <summary>
    /// Obter algumas marcas
    /// </summary>
    /// <returns></returns>
    public IEnumerable<MarcaVitrine> ObterMarcas()
    {
      return _context.MarcaVitrine.OrderBy(m => m.MarcaDescricao);
    }

    public IEnumerable<ClubesNacionais> ObterClubesNacionais()
    {
      return _context.ClubesNacionais.OrderBy(c => c.LinhaDescricao);
    }

    public IEnumerable<ClubesInternacionais> ObterClubesInternacionais()
    {
      return _context.ClubesInternacionais.OrderBy(c => c.LinhaDescricao);
    }

    //Obtenho as categorias pré definidas através da query na tabela categoria
    public IEnumerable<Categoria> ObterTenisCategoria()
    {
      var categorias = new[] { "0005", "0082", "0112", "0010", "0006", "0063" };
      return _context.Categorias.Where(c => categorias.Contains(c.CategoriaCodigo)).OrderBy(c => c.CategoriaDescricao);
    }

    //Subgrupo tenis
    public SubGrupo SubGrupoTenis()
    {
      return _context.SubGrupos.FirstOrDefault(s => s.SubGrupoCodigo == "0084");
    }

    #region [Menu Lateral Casual]

    /// <summary>
    /// Retorno a modalidade Casual
    /// </summary>
    /// <returns></returns>
    public Modalidade ModalidadeCasual()
    {
      const string CODIGOMODALIDADE = "0001";
      return _context.Modalidades
          .FirstOrDefault(m => m.ModalidadeCodigo == CODIGOMODALIDADE);
    }

    //SubGrupoDto
    public IEnumerable<SubGrupoDto> ObterCasualSubGrupo()
    {

      var subGrupos = new[] { "0001", "0102", "0103", "0738", "0084", "0921" };

      var query = from s in _context.SubGrupos
          .Where(s => subGrupos.Contains(s.SubGrupoCodigo))
          .Select(s => new { s.SubGrupoCodigo, s.SubGrupoDescricao })
          .Distinct()
          .OrderBy(s => s.SubGrupoDescricao)
                  select new
                  {
                    s.SubGrupoCodigo,
                    s.SubGrupoDescricao
                  };
      return query.Project().To<SubGrupoDto>().ToList();
    }

    #endregion [Menu Lateral Casual]

    #region [Suplementos]

    public Categoria Suplemento()
    {
      var categoriaSuplementos = "0008";

      return _context.Categorias
          .FirstOrDefault(s => s.CategoriaCodigo == categoriaSuplementos);
    }

    public IEnumerable<SubGrupo> ObterSuplementos()
    {
      var subGrupos = new[]
      {
                "0162","0381","0557","0564","0565","1082","1083","1084","1085", "0977"
            };
      return _context.SubGrupos
          .Where(s => subGrupos.Contains(s.SubGrupoCodigo) && s.GrupoCodigo == "0012")
          .OrderBy(s => s.SubGrupoDescricao);
    }
    #endregion
  }
}
