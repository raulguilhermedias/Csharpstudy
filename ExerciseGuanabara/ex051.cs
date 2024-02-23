namespace ExerciseGuanabara
{
    class Ex51
    {
        public static void Exercise51()
        {
            Console.WriteLine("================================");
            Console.WriteLine("     10 TERMOS DE UMA PA");
            Console.WriteLine("================================");

            Console.WriteLine("Primeiro termo: ");
            var term = int.Parse(Console.ReadLine());
            Console.WriteLine("Razão: ");
            var razao = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{term} ");
                term += razao;
            }


        }
    }
}