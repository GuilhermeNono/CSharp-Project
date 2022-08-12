using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Exercicios.Models
{
    public class Fahrenheit
    {
        public double Celsius { get; set; }
        
        public double tempConvertida { get => Converter(); }

        private double Converter()
        {
            return Math.Round(((Celsius * 1.8) + 32), 2);
        }
    }
}