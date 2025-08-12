using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Ejercicio1.Models
{
    internal class Circulo
    {
        public double circunferencia { get; set; }

        public Circulo(double radio)
        {
            circunferencia = radio;
        }

        public double calcularArea()
        {
            return Math.PI * circunferencia * circunferencia;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Circulo"",
                ""Radio"": {this.circunferencia},
                ""Área"": {this.calcularArea()}
            }}";
            return json;
        }
    }
}
