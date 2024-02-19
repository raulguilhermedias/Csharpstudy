namespace ExerciseGuanabara
{
    class Ex28
    {
        public static void Exercise28()
        {
            Random rng = new Random();
            int Rng = rng.Next(0, 5);
            Console.WriteLine("Estou pensando em um número entre 0 e 5, Tente adivinhar... ");
            Console.WriteLine("Em que número eu pensei? ");
            var result = int.Parse(Console.ReadLine());
            Console.WriteLine("Processando...");
            Thread.Sleep(2000);
            if (result == Rng)
            {
                Console.WriteLine("Parabéns você acertou");
            }
            else
            {
                Console.WriteLine($"Pensei no número {Rng} e você errou com o resultado {result} ");
            }
        }
    }
}