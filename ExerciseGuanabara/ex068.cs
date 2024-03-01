namespace ExerciseGuanabara
{
    class Ex68
    {

        public static void Exercise68()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("VAMOS JOGAR PAR OU IMPAR");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Random rng = new Random();
            var c = 0;
            while (true)
            {
                Console.WriteLine("Digite um número: ");
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("Par ou Impar ? [P/I]");
                var pi = char.Parse(Console.ReadLine().ToUpper());
                var pc = rng.Next(1, 10);
                var soma = n + pc;
                if (soma % 2 == 0 && pi == 'P')
                {
                    Console.WriteLine($"Você escolheu {n} e o pc {pc}. A Soma deu {soma}. DEU PAR!");
                    Console.WriteLine("VOCÊ GANHOU!");
                    c++;
                }else if (soma % 2 == 0 && pi == 'I')
                {
                    Console.WriteLine($"Você escolheu {n} e o pc {pc}. A Soma deu {soma}. DEU PAR!");
                    Console.WriteLine("VOCÊ PERDEU!");
                    break;
                }else if (soma % 2 != 0 && pi == 'I'){
                    Console.WriteLine($"Você escolheu {n} e o pc {pc}. A Soma deu {soma}. DEU IMPAR!");
                    Console.WriteLine("VOCÊ GANHOU!");
                    c++;
                }else if (soma % 2 != 0 && pi == 'P'){
                    Console.WriteLine($"Você escolheu {n} e o pc {pc}. A Soma deu {soma}. DEU IMPAR!");
                    Console.WriteLine("VOCÊ PERDEU!");
                    break;
                }
            }
            Console.WriteLine($"GAME OVER! Você venceu {c} vezes.");
        }
    }
}
/*
                if (pi == 'I')
                {
                    pipc = 'P';
                }
                if (soma % 2 == 0)
                {
                    if (pi == 'P')
                    {
                        Console.WriteLine("VOCÊ GANHOU!");
                    }
                    else
                    {
                        Console.WriteLine("VOCÊ PERDEU!");
                    }
                }
                if (soma % 2 != 0)
                {
                    pori = "IMPAR";
                    if (pi == 'I')
                    {
                        Console.WriteLine("VOCÊ GANHOU!");
                    }
                    else
                    {
                        Console.WriteLine("VOCÊ PERDEU!");
                    }
                }
*/