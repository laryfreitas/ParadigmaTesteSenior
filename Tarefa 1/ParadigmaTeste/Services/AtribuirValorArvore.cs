using ParadigmaTeste.Interfaces;
using ParadigmaTeste.Models;
using System;
using System.Linq;

namespace ParadigmaTeste.Services
{
  public class AtribuirValorArvore : IAtribuirValorArvore
  {
    public ArvoreProps GetArvoreProps(int[] arrayEntrada)
    {
      ArvoreProps arvoreProps = new ArvoreProps();
      arvoreProps.Raiz = GetRaizArvore(arrayEntrada);
      arvoreProps.GalhoDireito = GetGalhoDireito(arrayEntrada, arvoreProps.Raiz);
      arvoreProps.GalhoEsquerdo = GetGalhoEsquerdo(arrayEntrada, arvoreProps.Raiz);

      return arvoreProps;
    }

    private int GetRaizArvore(int[] arrayEntrada)
    {
      return arrayEntrada.Max();
    }

    private int[] GetGalhoDireito(int[] arrayEntrada, int raiz)
    {
      int indiceRaiz = Array.IndexOf(arrayEntrada, raiz);
      int[] arrayModficado = new int[arrayEntrada.Length - indiceRaiz - 1];
      Array.Copy(arrayEntrada, indiceRaiz + 1, arrayModficado, 0, arrayEntrada.Length - indiceRaiz - 1);
      return OrdenarGalhos(arrayModficado);
    }

    private int[] GetGalhoEsquerdo(int[] arrayEntrada, int raiz)
    {
      int indiceRaiz = Array.IndexOf(arrayEntrada, raiz);
      int[] arrayModficado = new int[indiceRaiz];
      Array.Copy(arrayEntrada, 0, arrayModficado, 0, indiceRaiz);
      return OrdenarGalhos(arrayModficado);
    }

    private int[] OrdenarGalhos(int[] arrayEntrada)
    {
      Array.Sort(arrayEntrada);
      Array.Reverse(arrayEntrada);
      return arrayEntrada;
    }
  }
}