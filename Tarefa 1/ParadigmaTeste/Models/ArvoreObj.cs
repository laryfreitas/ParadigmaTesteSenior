using System.Collections.Generic;

namespace ParadigmaTeste.Models
{
  public class ArvoreObj
  {
    public string Pai { get; set; }
    public List<ArvoreObj> Filhos { get; set; } = new List<ArvoreObj>();

    public ArvoreObj(string pai)
    {
      Pai = pai;
    }
  }
}