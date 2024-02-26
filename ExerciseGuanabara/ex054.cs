namespace ExerciseGuanabara
{
    class Ex54
    {
        public static void Exercise54()
        {
            int maior = 0;
            int menor = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"Em que ano a {i} pessoa nasceu: ");
                var idade = int.Parse(Console.ReadLine());
                idade = 2024 - idade;
                if (idade >= 18){
                    maior++;
                }else{
                    menor++;
                }
            }
            Console.WriteLine($"Ao todo tivemos {maior} maiores de idade e {menor} menores de idade");
        }
    }
}