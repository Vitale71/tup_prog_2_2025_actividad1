using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cilindro
    {
        private List<Circulo> tapas = new List<Circulo>();
        private RectanguloDesarrollado lado;

        public Cilindro (double radio, double altura)
        {
            tapas.Add(new Circulo(radio));
            tapas.Add(new Circulo(radio));
            lado = new RectanguloDesarrollado(radio, altura);
        }

        public double CalcularArea()
        {
            double areaTapas = 0;
            foreach (Circulo b in tapas)
            {
                areaTapas += b.calcularArea();
            }

            double areaLado = 0;
            areaTapas += lado.CalcularArea();

            return areaTapas + areaLado;
        }

        public double CalcularVolumen()
        {
            return tapas[0].calcularArea() * lado.largo;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Cilindro"",
                ""Tapas"": {tapas[0].circunferencia},
                ""Lado"": {lado.largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;
        }
    }
}
