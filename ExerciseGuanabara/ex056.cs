using System.Windows.Markup;

namespace ExerciseGuanabara
{
    class Ex56
    {
        public static void Exercise56()
        {
            var maior = 0;
            var media = 0;
            var cuie = 0;
            var oldman = " ";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"----- {i + 1} pessoa -----");
                Console.WriteLine("Nome: ");
                var name = Console.ReadLine();
                Console.WriteLine("Idade: ");
                var idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexualidade: (M/F)");
                var sexo = Console.ReadLine();
                media += idade;
                if (i == 0)
                {
                    maior = idade;
                    oldman = name;
                }
                else
                {
                    if (idade > maior)
                    {
                        maior = idade;
                        oldman = name;
                    }
                }
                if (sexo == "f" && idade < 20)
                {
                    cuie++;
                }
            }
            media = media / 4;
            Console.WriteLine($"a media de idade do grupo vai ser {media}\nO homem mais velho tem {maior} anos e se chama {oldman}.\nAo todo são {cuie} mulheres com menos de 20 anos");
        }
    }
}