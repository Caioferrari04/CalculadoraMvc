using System.ComponentModel.DataAnnotations;

namespace CalculadoraMvc.Models;

public class Operacao {
    public Operacao()
    {
        Numero1 = 0;
        Numero2 = 0;
        TipoOperacao = "";
        Resultado = "";
    }

    public Operacao(int num1, int num2, string tipo, string resultado)
    {
        Numero1 = num1;
        Numero2 = num2;
        TipoOperacao = tipo;
        Resultado = resultado;
    }

    public int Numero1 { get; set; }

    public int Numero2 { get; set; }

    public string TipoOperacao { get; set; }

    public string Resultado { get; set; }
}
