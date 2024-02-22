namespace ExerciseGuanabara
{
    class Ex42
    {
        public static void Exercise42()
        {
            Console.WriteLine("Qual o comprimento da primeira reta? ");
            var r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento da segunda reta? ");
            var r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento da terceira reta? ");
            var r3 = double.Parse(Console.ReadLine());

            if (r1 + r2 > r3 && r1 + r3 > r2 && r2 + r3 > r1)
            {
                if (r1 == r2 && r1 == r3)
                {
                    Console.WriteLine("Os segmentos acima PODEM FORMAR um triangulo EQUILÁTERO");
                }
                else if (r1 == r2 && r1 != r3 || r1 == r3 && r1 != r2 || r2 == r3 && r2 != r1)
                {
                    Console.WriteLine("Os segmentos acima PODEM FORMAR um triangulo ISÓSCELES");
                }
                else {
                    Console.WriteLine("Os segmentos acima PODEM FORMAR um triangulo ESCALENO");
                }
            }
            else
            {
                Console.WriteLine("Os segmentos acima NÃO PODEM FORMAR um triangulo");
            }

        }
    }
}