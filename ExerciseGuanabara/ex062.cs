namespace ExerciseGuanabara
{
    class Ex62
    {

        public static void Exercise62()
        {
            Console.WriteLine("Gerador de PA");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Primeiro termo: ");
            var termo = int.Parse(Console.ReadLine());
            Console.WriteLine("Razão da PA: ");
            var razao = int.Parse(Console.ReadLine());
            var contador = 1;
            var total = 0;
            var mais = 10;
            while (mais != 0)
            {
                total = total + mais;
                while (contador <= total)
                {
                    Console.WriteLine(termo);
                    Console.WriteLine("↓");
                    termo += razao;
                    contador++;
                }
                Console.WriteLine("PAUSA");
                Console.WriteLine("Quantos termos você quer mostrar a mais?");
                mais = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Progressão finalizada com {total} termos mostrados.");
        }
    }
}
/*
while (contador != 0)
            {
                Console.WriteLine(termo);
                Console.WriteLine("↓");
                termo += razao;
                contador--;
                Console.WriteLine(total);
                if (contador == 1)
                {
                    Console.WriteLine("Quantos termos você quer mostrar a mais?");
                    contador += int.Parse(Console.ReadLine());
                    total += contador - 1;
                    if (contador == 1)
                    {
                        contador = 0;
                    }
                }
            }
            Console.WriteLine($"Progressão finalizada com {total} termos mostrados.");
*/