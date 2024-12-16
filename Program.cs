// See https://aka.ms/new-console-template for more information

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
            Console.WriteLine("El perímetro del círculo es: " + circulo.CalcularPerimetro());

            // Crear un rectángulo con base 4 y altura 3
            Rectangulo rectangulo = new Rectangulo(4, 3);
            Console.WriteLine("El área del rectángulo es: " + rectángulo.CalcularArea());
            Console.WriteLine("El perímetro del rectángulo es: " + rectángulo.CalcularPerimetro());
        }
    }

    // Clase para representar un círculo
    class Circulo
    {
        private double radio; // Atributo privado para almacenar el radio

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un rectángulo
    class Rectangulo
    {
        private double baseRectangulo;
        private double altura;

        // Constructor para inicializar la base y la altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }
}