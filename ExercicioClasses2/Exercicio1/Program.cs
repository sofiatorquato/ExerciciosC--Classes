using System;
using System.Globalization;

namespace ExercicioClasses2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
como mostrado no projeto ao lado. */

            Retangulo x = new Retangulo();

            Console.WriteLine("Informe a largura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura do retângulo: ");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double AreaRetangulo = x.Area();
            double PerimetroRetangulo = x.Perimetro();
            double DiagonalRetangulo = x.Diagonal();

            Console.WriteLine($"ÁREA: {AreaRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO: {PerimetroRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {DiagonalRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}