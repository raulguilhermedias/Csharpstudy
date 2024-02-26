using System.Net.Mail;
using System.Reflection.PortableExecutable;

namespace ExerciseGuanabara
{
    class Ex55
    {
        public static void Exercise55()
        {
            double maior = 0;
            double menor = 0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Qual o peso da {i + 1} pessoa: ");
                var peso = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = peso;
                    menor = peso;
                }
                else
                {
                    if (peso > maior)
                    {
                        maior = peso;
                    }
                    else if (peso < menor)
                    {
                        menor = peso;
                    }
                }
            }
            Console.WriteLine($"O maior peso foi de {maior}Kg");
            Console.WriteLine($"O menor peso foi de {menor}Kg");
        }
    }
}