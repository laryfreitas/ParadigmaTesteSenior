using ParadigmaTeste.Models;
using System;

namespace ParadigmaTeste.Services
{
  public class MostrarArvoreServer
  {
    public static void ImprimirArvore(ArvoreObj laco, string prefixo, bool ehUltimo)
    {
      Console.WriteLine(prefixo + (ehUltimo ? "└── " : "├── ") + laco.Pai);

      prefixo += ehUltimo ? "    " : "│   ";

      for (int i = 0; i < laco.Filhos.Count; i++)
        ImprimirArvore(laco.Filhos[i], prefixo, i == laco.Filhos.Count - 1);
    }
  }
}