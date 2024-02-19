using System;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace ExerciseGuanabara
{
    class Exercise
    {
        static void Main(string[] args)
        {
            Ex30.Exercise30();
        }
    }
    // Exercicio 24
    // Console.WriteLine("Digite o nome da cidade onde nasceu: ");
    // var city = (Console.ReadLine());
    // Console.WriteLine(city.Substring(0, 5).ToUpper() == "SANTO");
    // Exercicio 21
    // Console.WriteLine("Digite um valor: ");
    // var valor = (Console.ReadLine());
    // var und = valor[3];
    // var dezen = valor[2];
    // var centen = valor[1];
    // var milhar = valor[0];
    // Console.WriteLine($"Unidade {und}");
    // Console.WriteLine($"Dezena {dezen}");
    // Console.WriteLine($"Centena {centen}");
    // Console.WriteLine($"Milhar {milhar}");
    // Exercicio 20
    // Console.WriteLine("Digite seu nome completo: ");
    // var name = Console.ReadLine();
    // var up = name.ToUpper();
    // var low = name.ToLower();
    // char espaco = ' ';
    // int contador = name.Count(c => c == espaco);
    // var number = (name.Length) - (contador);
    // string[] partes = name.Split(" ");
    // Console.WriteLine($"Seu nome em maiúsculo é: {up}\nSeu nome em minúsculo é: {low}\nSeu nome tem ao todo {number} caracteres\nSeu primeiro nome é {partes[0]} e tem {partes[0].Length} letras");

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