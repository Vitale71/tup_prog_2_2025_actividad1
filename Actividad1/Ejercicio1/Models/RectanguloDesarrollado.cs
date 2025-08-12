using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RectanguloDesarrollado
    {
        public double ancho { get; set; }
        public double largo { get; set; }

        public RectanguloDesarrollado(double radio, double altura)
        {
            ancho = radio * 2 * Math.PI;
            largo = altura;
        }

        public double CalcularArea()
        {
            return ancho * largo;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""RectanguloDesarrollado"",
                ""Ancho"": {this.ancho},
                ""Largo"": {this.largo},
                ""Área"": {this.CalcularArea()}
            }}";
            return json;
        }
    }
}
