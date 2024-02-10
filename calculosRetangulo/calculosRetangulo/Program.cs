// See https://aka.ms/new-console-template for more information
using calculosRetangulo;
using System.Globalization;

/*Fazer um programa para ler os valores da largura e altura de um retangulo e 
 * calcular o valor de sua área, perímetro e diagonal.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo t = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retangulo:");
        t.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        t.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(t);
    }
}