using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cubo
    {
        private List<Cuadrado> caras = new List<Cuadrado>();

        public Cubo(double lado)
        {
            for (int i = 0; i < 6; i++)
            {
                caras.Add(new Cuadrado(lado));
            }
        }

        public double CalcularArea()
        {
            return caras[0].calcularArea() * 6;
        }

        public double CalcularVolumen()
        {
            return caras[0].calcularArea() * caras[0].Largo;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Cubo"",
                ""Lado"": {caras[0].Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;
        }
    }
}
