namespace ExerciseGuanabara
{
    class Ex69
    {

        public static void Exercise69()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("   Cadastre uma Pessoa   ");
            Console.WriteLine("-------------------------");
            var total = 0;
            var men = 0;
            var woman = 0;
            while (true)
            {
                Console.WriteLine("Idade: ");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo: [M/F]");
                var sex = char.Parse(Console.ReadLine().ToUpper());
                if (sex == 'F' && id > 18){
                    woman++;
                }
                if (sex == 'M'){
                    men++;
                }
                if (id > 18){
                    total++;
                }
                Console.WriteLine("Quer continuar? [S/N]");
                var op = char.Parse(Console.ReadLine().ToUpper());
                if (op == 'N')
                {
                    break;
                }
            }
            Console.WriteLine($"Total de pessoas com mais de 18 anos {total}");
            Console.WriteLine($"Ao todo temos {men} homens cadastrados");
            Console.WriteLine($"E temos {woman} mulheres com menos de 20 anos");
        }
    }
}