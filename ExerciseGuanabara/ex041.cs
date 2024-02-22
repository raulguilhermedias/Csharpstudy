namespace ExerciseGuanabara
{
    class Ex41
    {
        public static void Exercise41()
        {
            Console.WriteLine("Ano de Nascimento: ");
            var year = int.Parse(Console.ReadLine());
            var data = new DateTime();
            data = DateTime.Now;
            var anos = data.Year - year;

            Console.WriteLine($"O Atleta tem {anos} anos.");
            if (anos <= 9)
            {
                Console.WriteLine("Classificado como MIRIM.");

            }
            else if (anos <= 14)
            {
                Console.WriteLine("Classificado como INFANTIL.");

            }
            else if (anos <= 19)
            {
                Console.WriteLine("Classificado como JUNIOR.");

            }
            else if (anos <= 25)
            {
                Console.WriteLine("Classificado como SENIOR.");

            }
            else if (anos > 25)
            {
                Console.WriteLine("Classificado como MASTER.");

            }


        }

    }
}