namespace ExerciseGuanabara
{
    class Ex37
    {
        public static void Exercise37()
        {
            Console.WriteLine("Digite um numero inteiro? ");
            var n = int.Parse(Console.ReadLine());
            var binario = Convert.ToString(n, 2);
            var octal = Convert.ToString(n, 8);
            var hexa = Convert.ToString(n, 16);
            Console.WriteLine("Escolha uma das bases para conversão:");
            Console.WriteLine("[1] converter para BINARIO");
            Console.WriteLine("[2] converter para OCTAL");
            Console.WriteLine("[3] converter para HEXADECIMAL");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Console.WriteLine($"{n} convertido para BINARIO é: {binario}"); break;
                case 2: Console.WriteLine($"{n} convertido para OCTAL é: {octal}"); break;
                case 3: Console.WriteLine($"{n} convertido para HEXADECIMAL é: {hexa}"); break;
                default: Exercise37(); break;
            }

    }
}
}