using System;

namespace ExerciseGuanabara
{
    class Ex25
    {
        public static void Exercise25()
        {
            Console.WriteLine("Digite seu nome: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Seu nome tem Silvia? {name.ToUpper().Contains("SILVIA")}");
        }
    }
}