namespace ExerciseGuanabara
{
    class Ex70
    {

        public static void Exercise70()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("   LOJA SUPER BARATÃO   ");
            Console.WriteLine("-------------------------");
            double total = 0;
            var maior = 0;
            var cheap = 0;
            while (true)
            {
                Console.WriteLine("Nome do produto: ");
                var product = Console.ReadLine().ToUpper();
                Console.WriteLine("Preço: R$");
                var price = double.Parse(Console.ReadLine());
                total += price;
                Console.WriteLine("Preço: R$");
                var op = char.Parse(Console.ReadLine());
                while (op != 'N'){
                    break;
                }
            }
            Console.WriteLine("------------FIM DO PROGRAMA--------------");
            Console.WriteLine($"O Total da compra foi R${total}");
            Console.WriteLine("Temos {x} produto custando mais que R$1000.00");
            Console.WriteLine("O produto mais barato foi {x} que custa {x}");
        }
    }
}