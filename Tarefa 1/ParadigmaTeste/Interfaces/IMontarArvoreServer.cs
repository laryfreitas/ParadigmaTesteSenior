using System.Collections.Generic;

namespace ParadigmaTeste.Interfaces
{
  public interface IMontarArvoreServer
  {
    void MontarArvore(List<(string pai, string filho)> pares);
  }
}