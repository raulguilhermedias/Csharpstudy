namespace ExerciseGuanabara
{
    class Ex50
    {
        public static void Exercise50()
        {
            var soma = 0;
            var cont = 0;
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"Digite o {i} valor: ");
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    soma += n;
                    cont += 1;
                }
            }
            Console.WriteLine($"Você informou {cont} numeros PARES e a soma foi {soma}");
        }
    }
}