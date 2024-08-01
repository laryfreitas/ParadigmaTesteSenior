using ParadigmaTeste.Properties;
using ParadigmaTeste.Services;
using System;
using System.Collections.Generic;
using Xunit;

public class MontarArvoreServerTests
{
  [Fact]
  public void MontarArvore_DeveCriarArvoreCorretamente()
  {
    // Arrange
    var montarArvoreServer = new MontarArvoreServer();
    var pares = new List<(string pai, string filho)>
        {
            ("A", "B"),
            ("A", "C"),
            ("B", "D"),
            ("C", "E")
        };

    // Act
    var output = ConsoleHelper.CaptureConsoleOutput(() => montarArvoreServer.MontarArvore(pares));

    // Assert
    Assert.Contains("└──", output);
  }

  [Fact]
  public void MontarArvore_DeveLancarExcecaoParaCiclo()
  {
    // Arrange
    var montarArvoreServer = new MontarArvoreServer();
    var pares = new List<(string pai, string filho)>
        {
            ("A", "B"),
            ("B", "C"),
            ("C", "A")
        };

    // Act
    var ex = Assert.Throws<Exception>(() => montarArvoreServer.MontarArvore(pares));

    // Assert
    string msgEsperada = "Não foi possivel construir a árvore. Erro: Ciclo presente.";
    Assert.Equal(msgEsperada, ex.Message);
  }

  [Fact]
  public void MontarArvore_DeveDetectarRaizesMultiplas()
  {
    // Arrange
    var montarArvoreServer = new MontarArvoreServer();
    var pares = new List<(string pai, string filho)>
        {
            ("A", "B"),
            ("A", "C"),
            ("B", "D"),
            ("C", "D"),
        };

    // Act
    var output = ConsoleHelper.CaptureConsoleOutput(() => montarArvoreServer.MontarArvore(pares));

    // Assert
    Assert.Contains(Resource.MsgErro3, output);
  }

  [Fact]
  public void MontarArvore_DeveDetectarMaisDeDoisFilhos()
  {
    // Arrange
    var montarArvoreServer = new MontarArvoreServer();
    var pares = new List<(string pai, string filho)>
        {
            ("A", "B"),
            ("A", "C"),
            ("A", "D")
        };

    // Act
    var output = ConsoleHelper.CaptureConsoleOutput(() => montarArvoreServer.MontarArvore(pares));

    // Assert
    Assert.Contains(Resource.MsgErro1, output);
  }
}