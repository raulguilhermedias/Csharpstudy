using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8f;
            string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);
            inteiro = Convert.ToInt32(real);

            Console.WriteLine(inteiro);
        }
    }
}

/* 
var -> é sempre um valor que pode ser mudado, porém deve seguir o seu tipo inicialmente informado, por exemplo:
var idade = 15; -> este valor inicialmente informado é de um INT e só poderá ser mudado para numeros inteiros.

const -> constantes são valores que não podem ser mudados uma vez que já foram informados, por exemplo:
const idade = 15; -> a idade será sempre 15.

int -> numeros inteiros, sem virgula ou ponto. E são eles: short/ushort | int/uint | long/ulong |

float -> numeros reais ou flutuantes, são os numeros que possuem virgula ou ponto, por exemplo: float peso = 65.50f; são eles: float | double | decimal, sendo o double o seu padrão.

bool -> valores boleanos, true or false

char -> Utilizado para armazenar 1 caractere e deve ser usado aspas simples, por exemplo: char genero = 'm'; 

object -> pode ser usado para atribuir qualquer tipo de valor.

Nullabel Types -> valores nulos e devem ser usados com o ? na frente de seu tipo, por exemplo: int? idade = null;
*/