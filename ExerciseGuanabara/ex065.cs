namespace ExerciseGuanabara
{
    class Ex65
    {

        public static void Exercise65()
        {
            double n = 0;
            var op = 'S';
            double res = 0;
            double cont = 0;
            double maior = 0;
            double menor = 0;
            while (op == 'S')
            {
                Console.WriteLine("Digite um número: ");
                n = double.Parse(Console.ReadLine());
                Console.WriteLine("Quer continuar? [S/N]");
                op = char.Parse(Console.ReadLine().ToUpper());
                res += n;
                cont++;
                if (cont == 1)
                {
                    maior = n;
                    menor = n;
                }
                else if (n > maior)
                {
                    maior = n;
                }
                else if (n < menor)
                {
                    menor = n;
                }
            }
            Console.WriteLine($"Você digitou {cont} números e a média foi de: {res / cont}");
            Console.WriteLine($"O maior valor foi {maior} e o menor foi {menor}");
        }
    }
}