namespace ExerciseGuanabara
{
    class Ex32
    {
        public static void Exercise32()
        {
            Console.WriteLine("Que ano quer analisar? Digite 0 para analisar o ano atual: ");
            var year = int.Parse(Console.ReadLine());
            var data = new DateTime();
            data = DateTime.Now;
            if (year == 0)
            {
                year = data.Year;
            }

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"O ano {year} é BISSEXTO");
            }
            else
            {
                Console.WriteLine($"O ano {year} não é BISSEXTO");
            }
        }
    }
}