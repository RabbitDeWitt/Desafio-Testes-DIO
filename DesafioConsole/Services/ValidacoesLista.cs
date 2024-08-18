using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConsole.Services
{
  public class ValidacoesLista
  {
    public int[] RemoverNumerosNegativos(int[] numeros)
    {
      List<int> numeroPositivos = new List<int>();

      foreach (int numero in numeros)
      {
        if (numero >= 0)
        {
          numeroPositivos.Add(numero);
        }
      }

      return numeroPositivos.ToArray();
    }

    public bool ListaContemDeterminadoNumero(int[] numeros, int x)
    {
      List<int> lista = new List<int>(numeros);
      return lista.Contains(x);

    }
  
    public int[] MultiplicarNumerosLista(int[] numeros, int multiplicador)
    {
      var resultados = numeros.Select(numero => numero * multiplicador);

      return resultados.ToArray();
    }
 
    public int RetornarMaiorNumeroLista(int[] numeros)
    {
      return numeros.Max();
    }
    
    public int RetornarMenorNumeroLista(int[] numeros)
    {
      return numeros.Min();
    }



  }
}
