using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace ExerciseGuanabara
{
    class Exercise
    {
        static void Main(string[] args)
        {
            // Exercicio 20
            Console.WriteLine("Primeiro aluno: ");
            var alun1 = Console.ReadLine();
            Console.WriteLine("Segundo aluno: ");
            var alun2 = Console.ReadLine();
            Console.WriteLine("Terceiro aluno: ");
            var alun3 = Console.ReadLine();
            Console.WriteLine("Quarto aluno: ");
            var alun4 = Console.ReadLine();
            var list = new string[4] { alun1, alun2, alun3, alun4 };
            Random rng = new Random();
            rng.Shuffle(list);
            Console.WriteLine(list);

            // Exercicio 19
            // Console.WriteLine("Primeiro aluno: ");
            // var alun1 = Console.ReadLine();
            // Console.WriteLine("Segundo aluno: ");
            // var alun2 = Console.ReadLine();
            // Console.WriteLine("Terceiro aluno: ");
            // var alun3 = Console.ReadLine();
            // Console.WriteLine("Quarto aluno: ");
            // var alun4 = Console.ReadLine();
            // var lista = new string[4] { alun1, alun2, alun3, alun4 };
            // Random rnd = new Random();
            // var res = lista[rnd.Next(lista.Length)]; // o resultado ficou lista[numero randomico]
            // Console.WriteLine($"O aluno escolhido foi: {res}");


            // Exercicio 18
            // Console.WriteLine("Digite o ângulo que você deseja: ");
            // var ang = double.Parse(Console.ReadLine());
            // var sen = Math.Sin(Double.DegreesToRadians(ang));
            // var cos = Math.Cos(Double.DegreesToRadians(ang));
            // var tan = Math.Tan(Double.DegreesToRadians(ang));
            // Console.WriteLine($"O ângulo de {ang} tem o SENO de {Math.Round(sen, 2)} \nO ângulo de {ang} tem o COSSENO de {Math.Round(cos, 2)} \nO ângulo de {ang} tem o TANGENTE de {Math.Round(tan, 2)}");

            // Exercicio 17
            // Console.WriteLine("Comprimento do cateto oposto: ");
            // var co = double.Parse(Console.ReadLine());
            // Console.WriteLine("Comprimento do cateto adjacente: ");
            // var ca = double.Parse(Console.ReadLine());
            // var hi = Double.Hypot(co, ca);
            // // var hi = (Math.Pow(co, 2) + Math.Pow(ca, 2));
            // // hi = Math.Pow(hi, 0.5);
            // Console.WriteLine($"O resultado da hipotenusa é {Math.Round(hi, 2)}");

            // Exercicio 16
            // Console.WriteLine("Digite um valor: ");
            // var num = double.Parse(Console.ReadLine());
            // Console.WriteLine($"O valor digitado foi {num} e a sua porção inteira é {Math.Truncate(num)}");
        }
    }
}