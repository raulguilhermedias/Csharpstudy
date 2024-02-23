namespace ExerciseGuanabara
{
    class Ex49
    {
        public static void Exercise49()
        {
            Console.WriteLine("Digite um número para ver sua tabuada");
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++){
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}