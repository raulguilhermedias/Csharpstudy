namespace ExerciseGuanabara
{
    class Ex59
    {

        public static void Exercise59()
        {
            Console.WriteLine("Primeiro valor: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var n2 = int.Parse(Console.ReadLine());
            short option = 0;
            while (option != 5)
            {
                Console.WriteLine("[ 1 ] Somar");
                Console.WriteLine("[ 2 ] Multriplicar");
                Console.WriteLine("[ 3 ] Maior");
                Console.WriteLine("[ 4 ] Novos números");
                Console.WriteLine("[ 5 ] Sair");
                Console.WriteLine(">>>>>>> Qual a sua opção?");
                option = short.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine($"A Soma entre {n1} + {n2} é {n1+n2}");
                }else if (option == 2)
                {
                    Console.WriteLine($"A multiplicação de {n1} x {n2} é {n1*n2}");
                }else if (option == 3){
                    if (n1 > n2){
                        Console.WriteLine($"O maior número é {n1}");
                    }else{
                        Console.WriteLine($"O maior número é {n2}");
                    }
                }else if (option == 4){
                    Console.WriteLine("Primeiro valor: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    n2 = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Finalizou o programa...");
        }
    }
}