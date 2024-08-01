using System.Collections.Generic;

namespace ParadigmaTeste.Interfaces
{
  public interface IUtilsServer
  {
    List<(string, string)> TransformaObjEmLista(string[] arrayEntrada);
  }
}