using System.Security;

namespace ExerciseGuanabara
{
    class Ex43
    {
        public static void Exercise43()
        {
            Console.WriteLine("Qual o peso de uma pessoa: (KG)");
            var peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura? (m)");
            var altura = double.Parse(Console.ReadLine());
            var Imc = (peso / altura) / altura;
            Imc = Math.Round(Imc, 1);
            Console.WriteLine($"O IMC dessa pessoa é de {Imc}");
            if (Imc < 18.5)
            {
                Console.WriteLine("Você está ABAIXO DO PESO");
            }
            else if (Imc > 18.5 && Imc < 25)
            {
                Console.WriteLine("Você está NO PESO IDEAL");
            }
            else if (Imc > 25 && Imc < 30)
            {
                Console.WriteLine("Você está NO SOBREPESO");
            }
            else if (Imc > 30 && Imc < 40)
            {
                Console.WriteLine("Você está NA OBESIDADE");
            }
            else if (Imc > 40)
            {
                Console.WriteLine("Você está NA OBESIDADE MORBIDA! CUIDADO!!!");
            }
        }
    }
}