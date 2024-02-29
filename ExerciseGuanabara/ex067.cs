namespace ExerciseGuanabara
{
    class Ex67
    {

        public static void Exercise67()
        {
            while (true)
            {
                Console.WriteLine("Digite um número: ");
                var n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    break;
                }
                Console.WriteLine("---------------------------");
                for (var c = 1; c < 11; c++){
                    Console.WriteLine($"{n} x {c} = {n * c}");
                }
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("PROGRAMA TABUADA ENCERRADO. Volte sempre!");
        }
    }
}