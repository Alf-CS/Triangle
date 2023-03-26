namespace Triangle
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquilatero_Click(object sender, EventArgs e)
        {

        }




        private void buttonLadoMayor_Click(object sender, EventArgs e)
        {
            if ((Triangulo.Lado1 == Triangulo.Lado2) & (Triangulo.Lado2 == Triangulo.Lado3))
            {
                Console.WriteLine("El triángulo es equilatero");
            }
            else
            {
                if (Triangulo.Lado1 < Triangulo.Lado2)
                {
                    if (Triangulo.Lado3 < Triangulo.Lado2) Console.WriteLine("El lado 2 es el lado mayor");
                    else Console.WriteLine("El lado 3 es el lado mayor");
                }
                else
                {
                    if (Triangulo.Lado3 < Triangulo.Lado1) Console.WriteLine("El lado 1 es el lado mayor");
                    else Console.WriteLine("El lado 3 es el lado mayor");
                }
            }

        }
    }



    public class Triangulo
    {
        public static int Lado1, Lado2, Lado3;
        double Area = 0;

        public void setLado1()
        {
            Lado1 = Form1.textBoxLado1.Text;
        }

        public void setLado2()
        {
            Lado2 = textBoxLado2.Text;
        }

        public void setLado3()
        {
            Lado3 = textBoxLado3.Text;
        }

        public double setArea()
        {
            double area = 0d;
            double s = (Lado1 + Lado2 + Lado3) / 2;
            area = Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
            Triangulo.Area = area;
        }
    }



}