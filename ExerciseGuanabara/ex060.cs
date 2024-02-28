namespace ExerciseGuanabara
{
    class Ex60
    {

        public static void Exercise60()
        {
            Console.WriteLine("Digite um número para calcular seu fatorial: ");
            var n = int.Parse(Console.ReadLine());
            var fatorial = 1;
            var contador = n;
            Console.WriteLine($"Calculando {n} = ");
            while (contador > 0)
            {
                Console.WriteLine($"{contador}");
                Console.WriteLine(contador > 1 ? "x" : "=");
                fatorial *= contador;
                contador--;
            }
            Console.WriteLine($"{fatorial}");
        }
    }
}