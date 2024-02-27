using Microsoft.VisualBasic;

namespace ExerciseGuanabara
{
    class Ex58
    {

        public static void Exercise58()
        {
            Random rng = new Random();
            var game = rng.Next(0, 10);
            var tentativas = 1;
            Console.WriteLine("Sou seu computador...");
            Console.WriteLine("Acabei de pensar em um número de 0 à 10.");
            Console.WriteLine("Será que você consegue adivinhar qual foi?");
            Console.WriteLine("Qual o seu palpite? ");
            var palpite = int.Parse(Console.ReadLine());
            while (palpite != game)
            {
                if (palpite < game)
                {
                    Console.WriteLine("Mais.. Tente mais uma vez.");
                    Console.WriteLine("Qual o seu palpite? ");
                    palpite = int.Parse(Console.ReadLine());
                    tentativas++;
                }
                else if (palpite > game)
                {
                    Console.WriteLine("Menos.. Tente mais uma vez.");
                    Console.WriteLine("Qual o seu palpite? ");
                    palpite = int.Parse(Console.ReadLine());
                    tentativas++;
                }
            }
            Console.WriteLine($"O número que pensei foi {game} Acertou com {tentativas} tentativas. Parabéns! ");
        }
    }
}