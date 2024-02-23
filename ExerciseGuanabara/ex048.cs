namespace ExerciseGuanabara
{
    class Ex48
    {
        public static void Exercise48()
        {
            var result = 501;
            int i = 1;
            var soma = 0;
            var valores = 0;
            for (i = 1; i < result; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                    valores += 1;
                }
                
            }
            Console.WriteLine($"A soma de {valores} valores é igual a {soma}");
            
        }
    }
}