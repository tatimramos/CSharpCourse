// See https://aka.ms/new-console-template for more information

using aumentoSalario;
using System.Globalization;

/*Escrever um programa para ler dados de um funcionario (nome, salário bruto e imposto).
 * Mostrar os dados do funcionario(nome e salário liquido).
 * Aumentar o salário do funcionario com base em uma porcentagem dada
 * Mostrar novamente os dados do funcionario.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salário Bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        func.SalarioLiquido();

        Console.WriteLine("Funcionario: " + func);
        Console.WriteLine();

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine();

        Console.WriteLine("Dados atualizadas: " + func);
    }
}