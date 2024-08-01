using ParadigmaTeste.Interfaces;
using ParadigmaTeste.Models;
using System;

namespace ParadigmaTeste.Services
{
  public class MontarArvore : IMontarArvore
  {
    public void ImprimirArvore(ArvoreProps arvoreValores)
    {
      int tamanhoContador = Math.Max(arvoreValores.GalhoDireito.Length, arvoreValores.GalhoEsquerdo.Length);

      Console.WriteLine("  " + arvoreValores.Raiz);
      Console.WriteLine(" /\\");

      for (int i = 0; i < tamanhoContador; i++)
      {
        if (i < arvoreValores.GalhoEsquerdo.Length && i < arvoreValores.GalhoDireito.Length)
        {
          Console.WriteLine(" " + arvoreValores.GalhoEsquerdo[i] + " " + arvoreValores.GalhoDireito[i]);
          if (i + 1 < tamanhoContador)
            Console.WriteLine(" / \\");
        }
        else if (i < arvoreValores.GalhoEsquerdo.Length)
        {
          Console.WriteLine(" " + arvoreValores.GalhoEsquerdo[i]);
          if (i + 1 < tamanhoContador)
            Console.WriteLine(" /");
        }
        else if (i < arvoreValores.GalhoDireito.Length)
        {
          Console.WriteLine(" " + arvoreValores.GalhoDireito[i]);
          if (i + 1 < tamanhoContador)
            Console.WriteLine("  \\");
        }
      }
    }
  }
}