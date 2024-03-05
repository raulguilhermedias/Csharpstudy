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
            var c = 0;
            double menor = 0;
            var nameMenor = " ";
            while (true)
            {
                Console.WriteLine("Nome do produto: ");
                var product = Console.ReadLine().ToUpper();
                Console.WriteLine("Preço: R$");
                var price = double.Parse(Console.ReadLine());
                total += price;
                c++;
                if (c == 1){
                    menor = price;
                }else if ( price < menor){
                    menor = price;
                    nameMenor = product;
                }
                if (price > 1000){
                    maior++;
                }
                Console.WriteLine("Quer continuar? [S/N]");
                var op = char.Parse(Console.ReadLine().ToUpper());
                if (op == 'N'){
                    break;
                }

            }
            Console.WriteLine("------------FIM DO PROGRAMA--------------");
            Console.WriteLine($"O Total da compra foi R${total}");
            Console.WriteLine($"Temos {maior} produto custando mais que R$1000.00");
            Console.WriteLine($"O produto mais barato foi {nameMenor} que custa R${menor}");
        }
    }
}