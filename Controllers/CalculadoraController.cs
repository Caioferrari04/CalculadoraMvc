using System.Collections.Generic;
using System.Linq;
using CalculadoraMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculadoraMvc.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Index() => View();
    
    [HttpPost]
    public IActionResult Resultado(Operacao operacao) 
    {
        double calculo = operacao.Numero1;

        switch (operacao.TipoOperacao)
        {
            case "soma": {
                operacao.Resultado += $"A soma de {operacao.Numero1} +";
                calculo += operacao.Numero2;
                break;
            }
            case "multiplicação": {
                operacao.Resultado += $"A multiplicação de {operacao.Numero1} *";
                calculo *= operacao.Numero2;
                break;
            }
            case "divisão": {
                operacao.Resultado += $"A divisão de {operacao.Numero1} /";
                calculo /= operacao.Numero2;
                break;
            }
            case "subtração": {
                operacao.Resultado += $"A subtração de {operacao.Numero1} -";
                calculo -= operacao.Numero2;
                break;
            }
            default: {
                throw new System.Exception("ahhhhhhhhhhhhhhhhhhh");
            }
        }

        operacao.Resultado += $" {operacao.Numero2} é igual à {calculo}";

        return View(operacao);
    } 
}
