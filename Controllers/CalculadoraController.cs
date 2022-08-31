using System.Collections.Generic;
using System.Linq;
using CalculadoraMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculadoraMvc.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Index() {
        List<SelectListItem> listItems = new List<SelectListItem>();
        listItems.Add(new SelectListItem() { Text = "Soma", Value = "soma", Selected = true });
        listItems.Add(new SelectListItem() { Text = "Multiplicação", Value = "multiplicação" });
        listItems.Add(new SelectListItem() { Text = "Divisão", Value = "divisão" });
        listItems.Add(new SelectListItem() { Text = "Subtração", Value = "subtração" });

        return View(new SelectList(listItems.AsEnumerable<SelectListItem>(), "Value", "Text"));
    } 
    [HttpPost]
    public IActionResult Resultado(Operacao operacao) 
    {
        var resultado = "";
        double calculo = operacao.Numero1;

        switch (operacao.TipoOperacao)
        {
            case "soma": {
                resultado += $"A soma de {operacao.Numero1} +";
                calculo += operacao.Numero1;
                break;
            }
            case "multiplicação": {
                resultado += $"A multiplicação de {operacao.Numero1} *";
                calculo *= operacao.Numero1;
                break;
            }
            case "divisão": {
                resultado += $"A divisão de {operacao.Numero1} /";
                calculo /= operacao.Numero1;
                break;
            }
            case "subtração": {
                resultado += $"A subtração de {operacao.Numero1} -";
                calculo -= operacao.Numero1;
                break;
            }
            default: {
                throw new System.Exception("ahhhhhhhhhhhhhhhhhhh");
            }
        }
        
        
        resultado += $" {operacao.Numero2} é igual à {calculo}";

        operacao.Resultado = resultado;

        return View(operacao);
    } 
}
