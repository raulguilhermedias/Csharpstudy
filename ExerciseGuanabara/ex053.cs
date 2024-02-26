using System.Threading.Tasks.Dataflow;

namespace ExerciseGuanabara
{
    class Ex53
    {
        public static void Exercise53()
        {
            Console.WriteLine("Digite uma frase: ");
            var frase = Console.ReadLine();
            string[] palavras = frase.Split();
            string junto = string.Join("", palavras);
            string inverso = "";

            for (int letra = junto.Length - 1; letra >= 0; letra--)
            {
                inverso += junto[letra];
            }

            Console.WriteLine($"O Inverso de {junto} é {inverso}");

            if (junto == inverso){
                Console.WriteLine("A frase é um palíndromo");
            }else
            {
                Console.WriteLine("A frase NÃO é um palíndromo");
            }
            
            // char[] caracters = frase.ToCharArray();
            // Array.Reverse(caracters);
            // string fraseInvertida = new string(caracters);
            // Console.WriteLine($"Você digitou a frase {fraseInvertida}");
            // if (fraseInvertida == frase)
            // {
            //     Console.WriteLine("A frase é um palíndromo");
            // }
            // else
            // {
            //     Console.WriteLine("A frase NÃO é um palíndromo");
            // }
        }
    }
}
/*
frase = str(input('digite uma frase: ')).strip().upper()
palavras = frase.split()
junto = ''.join(palavras)
inverso = ''
for letra in range(len(junto) - 1, -1, -1):
    inverso += junto[letra]
print(junto, inverso)

*/