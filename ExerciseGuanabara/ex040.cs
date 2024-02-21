namespace ExerciseGuanabara
{
    class Ex40
    {
        public static void Exercise40()
        {
            Console.WriteLine("Primeira nota: ");
            var n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            var n2 = double.Parse(Console.ReadLine());
            var media = (n1 + n2) / 2;
            Console.WriteLine($"Tirando {n1} e {n2} a média do aluno é {media}");
            if (media < 5)
            {
                Console.WriteLine($"O aluno está REPROVADO");
            }else if (media == 5 || media <= 6.9)
            {
                Console.WriteLine($"O aluno está de RECUPERAÇÃO");
            }else if (media >= 7){
                Console.WriteLine($"O aluno está APROVADO");
            }
        }

    }
}