using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class Tabuada
    {
        [Display(Name = "Número")]
        [Required(ErrorMessage = "Informe um Número de 1 a 10")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
        [Range(0, 10, ErrorMessage = "Informe um Número de 1 a 10")]
        public int Numero { get; set; } = 0;

        public TipoOperador Tipo { get; set; } = TipoOperador.While;

        public List<string> Resultado { get; private set; } = new();

        public void Calcular()
        {
            switch (Tipo)
            {
                case TipoOperador.While:
                    Resultado = CalcularWhile();
                    break;
                case TipoOperador.For:
                    Resultado = CalcularFor();
                    break;
                case TipoOperador.Repeat:
                    Resultado = CalcularRepeat();
                    break;
            }
        }       
        
        private List<string> CalcularWhile()
        {
            List<string> tabuada = new();
            int i = 0;
            while(i <= 10)
            {
                tabuada.Add($"{Numero} x {i} = {Numero * i}");
                i += 1;
            }
            return tabuada;
        }

        private List<string> CalcularFor()
        {
            List<string> tabuada = new();
            for(int i = 0; i <= 10; i++)
            {
                tabuada.Add($"{Numero} x {i} = {Numero * i}");
            }
            return tabuada;
        }

        private List<string> CalcularRepeat()
        {
            List<string> tabuada = new();
            int i = 0;
            do
            {
                tabuada.Add($"{Numero} x {i} = {Numero * i}");
                i += 1;
            } while (i <= 10);
            return tabuada;
        }

    }
}