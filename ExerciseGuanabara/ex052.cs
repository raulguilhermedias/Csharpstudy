using System.Linq.Expressions;

namespace ExerciseGuanabara
{
    class Ex52
    {
        public static void Exercise52()
        {
            Console.WriteLine("Digite um número: ");
            var num = int.Parse(Console.ReadLine());
            int total = 0;

            for (int c = 1; c <= num; c++)
            {
                if (num % c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    total++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(c);
            }
            Console.ResetColor();

            if (total == 2)
            {
                Console.WriteLine("É um número INTEIRO! ");
            }
            else
            {
                Console.WriteLine("NÃO É um número INTEIRO! ");
            }

        }
    }
}