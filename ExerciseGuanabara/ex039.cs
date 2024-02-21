namespace ExerciseGuanabara
{
    class Ex39
    {
        public static void Exercise39()
        {
            Console.WriteLine("Ano de nascimento: ");
            var year = int.Parse(Console.ReadLine());
            var data = new DateTime();
            data = DateTime.Now;
            var anoAtual = data.Year;
            var idade = anoAtual - year;
            var alistamento = 18;
            Console.WriteLine($"Quem nasceu em {year} tem {idade} anos em {anoAtual}.");
            if (idade < alistamento)
            {
                Console.WriteLine($"Ainda faltam {alistamento - idade} anos para o alistamento");
            }
            else if (idade > alistamento)
            {
                Console.WriteLine($"Você já deveria ter se alistado há {idade - alistamento} anos");
            }
            else if (idade == alistamento)
            {
                Console.WriteLine($"Você tem que se alistar IMEDIATAMENTE!");
            }
        }

    }
}