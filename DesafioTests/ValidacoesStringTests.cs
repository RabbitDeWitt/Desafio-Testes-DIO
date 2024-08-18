using DesafioConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTests
{
  public class ValidacoesStringTests
  {
    private ValidacoesString _validacoesString;

        public ValidacoesStringTests()
        {
            _validacoesString = new ValidacoesString();
        }

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
      Assert.Equal(6, _validacoesString.RetornarQuantidadeCaracteres("Matrix"));
    }

    [Fact]
    public void DeveConterAPalavraQualquerNoTexto()
    {
      string texto = "Esse é um texto qualquer";
      string palavraProcurada = "qualquer";
      Assert.True(_validacoesString.ContemCaractere(texto, palavraProcurada));
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
      string texto = "Esse é um texto qualquer";
      string palavraProcurada = "teste";
      Assert.False(_validacoesString.ContemCaractere(texto, palavraProcurada));
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
      string texto = "Começo, meio e fim do texto procurado";
      string palavraProcurada = "procurado";
      Assert.True(_validacoesString.TextoTerminaCom(texto, palavraProcurada));
    }
  }
}
