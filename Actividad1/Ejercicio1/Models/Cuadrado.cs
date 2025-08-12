using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cuadrado
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Cuadrado(double lado)
        {
            Ancho = lado;
            Largo = lado;
        }

        public double calcularArea()
        {
            return Ancho * Largo;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Cuadrado"",
                ""Lado"": {this.Largo},
                ""Área"": {this.calcularArea()}
            }}";
            return json;
        }
    }
}
