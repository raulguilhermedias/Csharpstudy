namespace ExerciseGuanabara
{
    class Ex36
    {
        public static void Exercise36()
        {
            Console.Clear();

            Console.WriteLine("Qual o valor do emprestimo? ");
            var emp = double.Parse(Console.ReadLine());
            Console.WriteLine("Em quantos anos pretende pagar o emprestimo? ");
            var year = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salario? ");
            year = year * 12;
            var salar = double.Parse(Console.ReadLine());
            var prest = Math.Round(emp / year, 2);
            var minimo = (salar * 30 / 100);
            Console.WriteLine($"Para pagar uma casa de {emp} em {year / 12} anos");
            Console.WriteLine($"A prestação será de R${prest}");
            if (prest >= minimo)
            {
                Console.WriteLine($"Emprestimo NEGADO!");
            }
            else
            {
                Console.WriteLine($"Emprestimo ACEITO");
            }
        }
    }
}