using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models;

public class Partida
{
    [Display(Name = "Nome do Time 1")]
    [Required(ErrorMessage = "Informe o Nome do Time")]
    [StringLength(30, ErrorMessage = "O Nome do Time deve possuir no máximo 30 caracteres")]
    public string Time1 { get; set; } = string.Empty;

    [Display(Name = "Gols do Time 1")]
    [Required(ErrorMessage = "Informe o Número de Gols do Time 1")]
    [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
    public int GolsTime1 { get; set; } = 0;

    [Display(Name = "Nome do Time 2")]
    [Required(ErrorMessage = "Informe o Nome do Time 2")]
    [StringLength(30, ErrorMessage = "O Nome do Time 2 deve possuir no máximo 30 caracteres")]
    public string Time2 { get; set; } = string.Empty;

    [Display(Name = "Gols do Time 2")]
    [Required(ErrorMessage = "Informe o Número de Gols do Time 2")]
    [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
    public int GolsTime2 { get; set; } = 0;

    public string Resultado
    {
        get
        {
            return GolsTime1 > GolsTime2 ? $"Vitória do {Time1}" :
                   GolsTime2 > GolsTime1 ? $"Vitória do {Time2}" :
                                           $"Empate entre {Time1} e {Time2}";
        }
    }
}
