using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Ortoedro
    {
        private List<Rectangulo> bases = new List<Rectangulo>();
        private List<Rectangulo> laterales = new List<Rectangulo>();

        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            bases.Add(new Rectangulo(anchoBase, ladoComun));
            bases.Add(new Rectangulo(anchoBase, ladoComun));

            for (int i = 0; i < 4; i++)
            {
                laterales.Add(new Rectangulo(ladoComun, largoLateral));
            }
        }

        public double CalcularArea()
        {
            double areaBases = 0;
            foreach (Rectangulo b in bases)
            {
                areaBases += b.CalcularArea();
            }

            double areaLaterales = 0;
            foreach (Rectangulo l in laterales)
            {
                areaLaterales += l.CalcularArea();
            }

            return areaBases + areaLaterales;
        }

        public double CalcularVolumen()
        {
            double areaBase = bases[0].CalcularArea();
            double altura = laterales[0].getLargo();
            return areaBase * altura;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Ortoedro"",
                ""Ancho base"": {bases[0].Ancho},
                ""Largo base"": {bases[0].Largo},
                ""Largo lateral"": {laterales[0].Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;
        }
    }
}
