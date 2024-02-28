namespace ExerciseGuanabara
{
    class Ex64
    {

        public static void Exercise64()
        {
            var n = 0;
            var soma = 0;
            var cont = 0;
            Console.WriteLine("Digite um número [999 - Para PARAR]: ");
            n = int.Parse(Console.ReadLine());
            while (n != 999)
            {
                soma += n;
                cont++;
                Console.WriteLine("Digite um número [999 - Para PARAR]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Você digitou {cont} números e a soma entre eles foi {soma}");
        }
    }
}