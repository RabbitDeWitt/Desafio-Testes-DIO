using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConsole.Services
{
  public class ValidacoesString
  {
    public int RetornarQuantidadeCaracteres(string texto)
    {
      return texto.Length;
    }

    public bool ContemCaractere(string texto, string textoProcurado)
    {
      return texto.Contains(textoProcurado);
    }

    public bool TextoTerminaCom(string texto, string ultimaPalavra)
    {
      return texto.EndsWith(ultimaPalavra);
    }
  }
}
