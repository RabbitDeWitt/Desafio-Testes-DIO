using DesafioConsole.Services;

namespace DesafioTests
{
  public class ValidacoesListaTests
  {
    private ValidacoesLista _validacoesLista;

    public ValidacoesListaTests()
    {
      _validacoesLista = new ValidacoesLista();
    }

    [Theory]
    [InlineData(new int[] { 1, 25, -5, 4, -1 }, new int[] { 1, 25, 4 })]
    [InlineData(new int[] { -10, 25, -5, 0, -1 }, new int[] { 25, 0 })]
    public void DeveRemoverNumerosNegativosDeUmaLista(int[] lista, int[] positivos)
    {
      Assert.Equal(positivos, _validacoesLista.RemoverNumerosNegativos(lista));
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
      int[] numeros = { 5, 8, 10, 9, 23 };

      Assert.True(_validacoesLista.ListaContemDeterminadoNumero(numeros, 9));
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
      int[] numeros = { 5, 8, 11, 9, 23 };
      Assert.False(_validacoesLista.ListaContemDeterminadoNumero(numeros, 10));
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
      int[] numeros = { 3, 8, 1 };
      int[] resultado = { 6, 16, 2 };
      Assert.Equal(resultado, _validacoesLista.MultiplicarNumerosLista(numeros, 2));
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
      int[] numeros = { 2, 9, 7, 6 };
      Assert.Equal(9, _validacoesLista.RetornarMaiorNumeroLista(numeros));
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
    {
      int[] numeros = { 0, 5, -8, 1 };
      Assert.Equal(-8, _validacoesLista.RetornarMenorNumeroLista(numeros));
    }
  }
}