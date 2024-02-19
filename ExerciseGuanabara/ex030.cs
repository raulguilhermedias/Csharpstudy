namespace ExerciseGuanabara
{
    class Ex30
    {
        public static void Exercise30()
        {
            Console.WriteLine("Digite um número: ");
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0){
                Console.WriteLine($"O número {num} é PAR");
            }else {
                Console.WriteLine($"O número {num} é IMPAR");
            }
        }
    }
}