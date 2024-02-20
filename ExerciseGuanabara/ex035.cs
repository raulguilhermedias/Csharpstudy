namespace ExerciseGuanabara
{
    class Ex35
    {
        public static void Exercise35()
        {
            Console.WriteLine("Qual o comprimento da primeira reta? ");
            var r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento da segunda reta? ");
            var r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento da terceira reta? ");
            var r3 = double.Parse(Console.ReadLine());
            if (r1 + r2 > r3 && r2 + r3 > r1 && r1 + r3 > r2){
                Console.WriteLine("PODE ser um Triangulo");
            }else{
                Console.WriteLine("NÃO Pode ser um Triangulo");
            }
            
        }
    }
}