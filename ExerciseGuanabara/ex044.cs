using System.Security;

namespace ExerciseGuanabara
{
    class Ex44
    {
        public static void Exercise44()
        {
            Console.WriteLine("Qual o valor da sua compra? ");
            var price = double.Parse(Console.ReadLine());
            var avista = price - (price * 10 / 100);
            var avcartao = price - (price * 5 / 100);
            var duasx = price / 2;
            var juros = price + (price * 20 / 100);
            Console.WriteLine("Qual a forma de pagamento?");
            Console.WriteLine("[1] A vista no dinheiro ou cheque");
            Console.WriteLine("[2] A vista no cartão");
            Console.WriteLine("[3] cartão 2x sem juros");
            Console.WriteLine("[4] cartão 3x ou mais com juros de 20%");
            Console.WriteLine("Qual a opção? ");
            short option = short.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            Thread.Sleep(500);
            switch (option)
            {
                case 1: Console.WriteLine($"Sua compra de R${price} vai custar R${avista} no final"); break;
                case 2: Console.WriteLine($"Sua compra de R${price} vai custar R${avcartao} no final"); break;
                case 3: Console.WriteLine($"Sua compra será parcelada em 2x de R${duasx} SEM JUROS\nSua compra de R${price} vai custar R${price} no final"); break;
                case 4: Console.WriteLine("Quantas parcelas? "); 
                var parcelas = double.Parse(Console.ReadLine()); 
                var result = juros / parcelas;
                Console.WriteLine($"Sua compra será parcelada em {parcelas}x de R${result} COM JUROS\nSua compra de R${price} vai custar R${juros} no final"); break;
                default: Ex44.Exercise44(); break;
            }

        }
    }
}