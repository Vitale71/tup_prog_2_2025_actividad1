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
            Rectangulo objeto2 = new Rectangulo(2, 4);
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            Cuadrado objeto4 = new Cuadrado(3);
            Cubo objeto5 = new Cubo(6);

            string resultado = "[\n" +
            objeto2.Describir() + ",\n" +
            objeto3.Describir() + ",\n" +
            objeto4.Describir() + ",\n" +
            objeto5.Describir() + "\n" +
            "]";

            textBox1.Text = resultado;
        }
    }
}
