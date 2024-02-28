namespace ExerciseGuanabara
{
    class Ex61
    {

        public static void Exercise61()
        {
            Console.WriteLine("Gerador de PA");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Primeiro termo: ");
            var termo = int.Parse(Console.ReadLine());
            Console.WriteLine("Razão da PA: ");
            var razao = int.Parse(Console.ReadLine());
            var contador = 10;
            while (contador != 0)
            {
                Console.WriteLine(termo);
                Console.WriteLine("↓");
                termo += razao;
                contador--;
            }
            Console.WriteLine("Fim");

        }
    }
}