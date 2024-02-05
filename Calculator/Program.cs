using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine($"O resultado da soma é: {v1+v2}");
        }
    }
}
