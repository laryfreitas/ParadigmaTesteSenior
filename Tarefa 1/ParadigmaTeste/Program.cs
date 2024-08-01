using ParadigmaTeste.Interfaces;
using ParadigmaTeste.Properties;
using ParadigmaTeste.Services;
using System;

namespace ParadigmaTeste
{
  public class Program
  {
    private static void Main(string[] args)
    {
      IMontarArvoreServer atribuirValorArvoreService = new MontarArvoreServer();
      IUtilsServer utilsServer = new UtilsServer();

      string[] entradaCenarioUm = { "A|B", "A|C", "B|G", "C|H", "E|F", "B|D", "C|E" };
      string[] entradaCenarioDois = { "B|D", "D|E", "A|B", "C|F", "E|G", "A|C" };
      string[] entradaCenarioTres = { "A|B", "A|C", "B|D", "D|C" };

      Console.WriteLine(Resource.Titulo1);
      atribuirValorArvoreService.MontarArvore(utilsServer.TransformaObjEmLista(entradaCenarioUm));

      Console.WriteLine(Environment.NewLine + Resource.Linha + Environment.NewLine);

      Console.WriteLine(Resource.Titulo2);
      atribuirValorArvoreService.MontarArvore(utilsServer.TransformaObjEmLista(entradaCenarioDois));

      Console.WriteLine(Environment.NewLine + Resource.Linha + Environment.NewLine);

      Console.WriteLine(Resource.Titulo3);
      atribuirValorArvoreService.MontarArvore(utilsServer.TransformaObjEmLista(entradaCenarioTres));

      Console.WriteLine(Environment.NewLine + Resource.Linha + Environment.NewLine);
    }
  }
}