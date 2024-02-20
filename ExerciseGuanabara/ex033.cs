namespace ExerciseGuanabara
{
    class Ex33
    {
        public static void Exercise33()
        {
            Console.WriteLine("Primeiro valor: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro valor: ");
            var n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3){
                Console.WriteLine($"O maior valor foi {n1}");
            } else if (n2 > n3 && n2 > n1){
                Console.WriteLine($"O maior valor foi {n2}");
            }else if (n3 > n2 && n3 > n1){
                Console.WriteLine($"O maior valor foi {n3}");
            }
            if (n1 < n2 && n1 < n3){
                Console.WriteLine($"O menor valor foi {n1}");
            } else if (n2 < n3 && n2 < n1){
                Console.WriteLine($"O menor valor foi {n2}");
            }else if (n3 < n2 && n3 < n1){
                Console.WriteLine($"O menor valor foi {n3}");
            }
        }

    }
}