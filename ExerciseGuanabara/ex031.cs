namespace ExerciseGuanabara
{
    class Ex31
    {
        public static void Exercise31()
        {
            Console.WriteLine("Qual a distância em km da viagem? ");
            var km = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você está prestes a começar uma viagem de {km}km.");
            if (km <= 200)
            {
                Console.WriteLine($"E o preço da passagem será de R${km * 0.50}");
            }
            else
            {
                Console.WriteLine($"E o preço da passagem será de R${km * 0.45}");
            }
        }
    }
}