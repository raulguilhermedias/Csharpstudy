using Microsoft.VisualBasic;

namespace ExerciseGuanabara
{
    class Ex34
    {
        public static void Exercise34()
        {
            Console.WriteLine("Qual o salário de um funcionário? ");
            var salario = double.Parse(Console.ReadLine());
            var result1 = salario +(salario * 10 / 100);
            var result2 = salario +(salario * 15 / 100);

            if (salario > 1250)
            {
                Console.WriteLine($"Quem ganhava R${salario} vai passar a ganhar R${result1}");
            }else
            {
                Console.WriteLine($"Quem ganhava R${salario} vai passar a ganhar R${result2}");
            }
        }
    }
}