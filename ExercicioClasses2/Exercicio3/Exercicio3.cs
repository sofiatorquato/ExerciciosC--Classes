using ExercicioClasses2.Exercicio3;
using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();


            Console.WriteLine("Informe o nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota que recebeu no primeiro trimestre: ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a nota que recebeu no segundo trimestre: ");
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a nota que recebeu no terceiro trimestre: ");
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{a}");
            Console.WriteLine("APROVADO");

            
                Console.WriteLine($"{a}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {a.Pontos().ToString("F2",CultureInfo.InvariantCulture)} pontos");
            

        }
    }
}