namespace ExerciseGuanabara
{
    class Ex66
    {

        public static void Exercise66()
        {
            var res = 0;
            var c = 0;
            while (true)
            {
                Console.WriteLine("Digite um número: ");
                var n = int.Parse(Console.ReadLine());
                if (n == 999)
                {
                    break;
                }
                res += n;
                c++;
            }
            Console.WriteLine($"A soma dos {c} valores foi de {res}");
        }
    }
}