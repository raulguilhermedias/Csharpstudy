namespace ExerciseGuanabara
{
    class Ex38
    {
        public static void Exercise38()
        {
            Console.WriteLine("Primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("O PRIMEIRO valor é maior ");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("O SEGUNDO valor é maior ");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("Os dois valores são IGUAIS ");
            }
        }

    }
}