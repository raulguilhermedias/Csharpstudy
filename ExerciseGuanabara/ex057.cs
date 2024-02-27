using Microsoft.VisualBasic;

namespace ExerciseGuanabara
{
    class Ex57
    {
        public static void Exercise57()
        {
            Console.WriteLine("Informe seu sexo: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            while (sexo != 'M' && sexo != 'F')
            {
                Console.WriteLine("Dados Inválidos. Informe seu sexo: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
            }
            Console.WriteLine($"Sexo {sexo} registrado com sucesso!");
        }
    }
}