using ParadigmaTeste.Interfaces;
using System.Collections.Generic;

namespace ParadigmaTeste.Services
{
  public class UtilsServer : IUtilsServer
  {
    public List<(string, string)> TransformaObjEmLista(string[] arrayEntrada)
    {
      List<(string, string)> pares = new List<(string, string)>();

      foreach (string item in arrayEntrada)
      {
        string[] par = item.Split('|');
        pares.Add((par[0], par[1]));
      }

      return pares;
    }
  }
}