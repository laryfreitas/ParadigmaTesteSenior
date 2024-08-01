using ParadigmaTeste.Interfaces;
using ParadigmaTeste.Models;
using ParadigmaTeste.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParadigmaTeste.Services
{
  public class MontarArvoreServer : MostrarArvoreServer, IMontarArvoreServer
  {
    private List<ArvoreObj> familia;
    private HashSet<string> filhos = new HashSet<string>();

    public void MontarArvore(List<(string pai, string filho)> pares)
    {
      try
      {
        if (ExisteMais2Filhos(pares))
          Console.WriteLine(Resource.MsgErro1);
        else if (ExisteRaizesMultiplas(pares))
          Console.WriteLine(Resource.MsgErro3);
        else
        {
          familia = new List<ArvoreObj>();

          foreach (var (pai, filho) in pares)
          {
            ArvoreObj lacoPai = EncontrarCriarLacos(pai);
            ArvoreObj lacoFilho = EncontrarCriarLacos(filho);

            if (ExisteCicloPresente(lacoPai, lacoFilho))
              throw new Exception(Resource.MsgErro2);

            lacoPai.Filhos.Add(lacoFilho);

            filhos.Add(filho);
          }

          ArvoreObj arvoreHierarquica = familia.Where(laco => !filhos.Contains(laco.Pai)).ToList()[0];

          ImprimirArvore(arvoreHierarquica, "", true);
        }
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format(Resource.MsgErro4, ex.Message));
      }
    }

    private ArvoreObj EncontrarCriarLacos(string valor)
    {
      ArvoreObj laco = familia.FirstOrDefault(n => n.Pai == valor);
      if (laco == null)
      {
        laco = new ArvoreObj(valor);
        familia.Add(laco);
      }
      return laco;
    }

    private bool ExisteRaizesMultiplas(List<(string pai, string filho)> pares)
    {
      HashSet<string> filhosLidos = new HashSet<string>();

      foreach (var item in pares)
      {
        if (filhosLidos.Contains(item.filho))
          return true;

        filhosLidos.Add(item.filho);
      }

      return false;
    }

    private bool ExisteMais2Filhos(List<(string pai, string filho)> pares)
    {
      Dictionary<string, int> paisLidos = new Dictionary<string, int>();

      foreach (var item in pares)
      {
        if (!paisLidos.ContainsKey(item.pai))
          paisLidos.Add(item.pai, 0);
        else
          paisLidos[item.pai]++;

        if (paisLidos[item.pai] >= 2)
          return true;
      }
      return false;
    }

    private bool ExisteCicloPresente(ArvoreObj pai, ArvoreObj filho)
    {
      HashSet<string> visitados = new HashSet<string>();
      Stack<ArvoreObj> lacoPaiFilho = new Stack<ArvoreObj>();

      lacoPaiFilho.Push(filho);

      while (lacoPaiFilho.Count > 0)
      {
        ArvoreObj lacoAtual = lacoPaiFilho.Pop();

        if (lacoAtual.Pai == pai.Pai)
          return true;

        if (visitados.Contains(lacoAtual.Pai))
          continue;

        visitados.Add(lacoAtual.Pai);

        foreach (var noFilho in lacoAtual.Filhos)
          lacoPaiFilho.Push(noFilho);
      }

      return false;
    }
  }
}