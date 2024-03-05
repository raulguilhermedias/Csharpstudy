using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace ExerciseGuanabara
{
    class Ex71
    {

        public static void Exercise71()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("             BANCO CEV              "); // 785
            Console.WriteLine("===================================="); // 15 * 50 = 750 - 785 = 35 - 20 = 15 - 10
            Console.WriteLine("Quanto você quer sacar? R$");
            var sacar = int.Parse(Console.ReadLine());
            var total = sacar;
            var ced = 50;
            var totced = 0;
            while (true)
            {
                if (total >= ced)
                {
                    total -= ced;
                    totced++;
                }
                else
                {
                    if (totced > 0){
                        Console.WriteLine($"Total de {totced} cédulas de R${ced}");
                    }
                    if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;
                    }
                    else if (ced == 10)
                    {
                        ced = 1;
                    }
                    totced = 0;
                    if (total == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
/*
cinquenta = sacar / 50; // 50 OK
                if (sacar % 50 != 0)
                {
                    var valor50 = cinquenta * 50; // 750
                    var menos50 = sacar - valor50; // 785 - 750 = 35
                    vinte = menos50 / 20; // 20 OK
                    if (menos50 % 20 != 0)
                    {
                        var valor20 = vinte * 20; // 20
                        var menos20 = menos50 - valor20; // 35 - 20 = 15
                        dez = menos20 / 10;// 10 OK
                        if (menos50 % 10 != 0)
                        {
                            var valor1 = dez * 10; // 10
                            var menos1 = menos20 - valor1; // 15 - 10 = 5
                            um = menos1 / 1; // 1 OK
                        }
                    }

                }
                break;
            }
            if (cinquenta > 0)
            {
                Console.WriteLine($"Total de {cinquenta} cédulas de R$50");
            }
            if (vinte > 0)
            {
                Console.WriteLine($"Total de {vinte} cédulas de R$20");
            }
            if (dez > 0)
            {
                Console.WriteLine($"Total de {dez} cédulas de R$10");
            }
            if (um > 0)
            {
                Console.WriteLine($"Total de {um} cédulas de R$1");
            }
            Console.WriteLine($"{cinquenta} {vinte} {dez} {um}");
*/