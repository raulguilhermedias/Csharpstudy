namespace ExerciseGuanabara
{
    class Ex63
    {

        public static void Exercise63()
        {
            Console.WriteLine("────────────────────────────────");
            Console.WriteLine("─────Sequência de Fibonacci─────");
            Console.WriteLine("────────────────────────────────");
            Console.WriteLine("Quantos termos você quer mostrar? ");
            var termo = int.Parse(Console.ReadLine());
            var seq = 3;
            var t1 = 0;
            var t2 = 1;
            var res = 0;
            Console.WriteLine($"{t1}\n↓\n{t2}\n↓");
            while (seq <= termo)
            {
                var t3 = t1 + t2;    // 0 1 1 2 3 5 8
                Console.WriteLine(t3);
                Console.WriteLine("↓");
                t1 = t2;
                t2 = t3;
                seq++;
            }
            Console.WriteLine("FIM");
        }
    }
}