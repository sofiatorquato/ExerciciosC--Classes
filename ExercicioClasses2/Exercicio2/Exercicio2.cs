using ExercicioClasses2.Exercicio2;
using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Fazer um programa para ler os dados de um funcionário (nome, 
salário bruto e imposto). Em seguida, mostrar os dados do 
funcionário (nome e salário líquido). Em seguida, aumentar o salário 
do funcionário com base em uma porcentagem dada (somente o 
salário bruto é afetado pela porcentagem) e mostrar novamente os 
dados do funcionário. Use a classe projetada abaixo. */

            Funcionario a = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto do funcionário: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do imposto: ");
            a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioTotal = a.SalarioLiquido();

            Console.WriteLine($"Funcionário: {a.Nome}, ${SalarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Digite a porcentagem para aumentar o salário: ");
            double Porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.AumentarSalario(Porcento);
            Console.WriteLine($"Dados atualizados: {a.Nome}, {a}");



        }
    }
}