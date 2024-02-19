namespace ExerciseGuanabara
{
    class Ex26
    {
        public static void Exercise26()
        {
            Console.WriteLine("Digite uma frase: ");
            var phrase = Console.ReadLine().ToUpper().Trim();
            char wordA = 'A';
            int contador = phrase.Count(a => a == wordA);
            Console.WriteLine($"A letra A aparece {contador} vezes na frase");
            Console.WriteLine($"A primeira letra A apareceu na posição {phrase.IndexOf("A")}");
            Console.WriteLine($"A última letra A apareceu na posição {phrase.LastIndexOf("A")}");
        }
    }
}