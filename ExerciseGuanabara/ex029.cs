namespace ExerciseGuanabara
{
    class Ex29
    {
        public static void Exercise29()
        {
            Console.WriteLine("Qual a velocidade de um carro? ");
            var vel = int.Parse(Console.ReadLine());
            var multa = (vel - 80) * 7.0;
            if (vel > 80)
            {
                Console.WriteLine($"MULTADO! Você deve pagar uma multa de R${multa}!");
            }
            Console.WriteLine("Tenha um bom dia, dirija sempre com segurança!");
        }
    }
}