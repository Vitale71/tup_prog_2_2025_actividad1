using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Rectangulo objeto1 = new Rectangulo(2, 4);
            Ortoedro objeto2 = new Ortoedro(7, 7, 21);
            Cuadrado objeto3 = new Cuadrado(3);
            Cubo objeto4 = new Cubo(6);
            Circulo objeto5 = new Circulo(1);
            RectanguloDesarrollado objeto6 = new RectanguloDesarrollado(1, 3);
            Cilindro objeto7 = new Cilindro(1, 3);

            string resultado = "[\n" +
            objeto1.Describir() + ",\n" +
            objeto2.Describir() + ",\n" +
            objeto3.Describir() + ",\n" +
            objeto4.Describir() + ",\n" +
            objeto5.Describir() + ",\n" +
            objeto6.Describir() + ",\n" +
            objeto7.Describir() + "\n" +
            "]";

            textBox1.Text = resultado;
        }
    }
}
