using System;
using System.ComponentModel.DataAnnotations;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutencao Eletrica residencial", 500, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
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

Operadadores condicionais -> exemplo:
            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            if (idade >= maioridade && idade < idadeMaxima){
                Console.WriteLine("é de maior");
            }else{
                Console.WriteLine("não é de maior");
            }
            Console.WriteLine("finalizou");

Switch - >  string valor = "andre";
            switch (valor)
            {
                case "joao": Console.WriteLine("Não é o cara"); break;
                case "marcelo": Console.WriteLine("Não é o cara"); break;
                case "andre": Console.WriteLine("É o cara"); break;
                default: Console.WriteLine("Não encontrei"); break;
            }

For ->         for (var i = 0; i <= 5; i++){
                Console.WriteLine(i);
            }

While ->    var valor = 0;
            while (true)
            {
                valor++;
                Console.WriteLine(valor);
            }

Do While -> var valor = 0;
            do {
                Console.WriteLine(valor);
                valor++;
            } while (valor < 5);
            Console.WriteLine(valor);

Metodos e funções -> 
        static void Main(string[] args)
        {
            MeuMetodo();

            string nome = RetornaNome("André", " Baltieri");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            int idade = 34,
            bool teste = false,
            double novo = 33.42
        ){
        
            return nome + sobrenome + " tem " + idade.ToString() + teste + novo;
        }
*/