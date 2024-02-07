using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append ("Este texto é um teste");
            texto.Append ("é um teste");
            texto.Append ("texto é um teste");
            texto.Append (" teste");

            texto.ToString();
            Console.WriteLine(texto);


            //Manipulando strings

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.Replace("Este", "isto"));
            // Console.WriteLine(texto.Replace("e", "X"));

            // var divisao = texto.Split(" ");
            // Console.WriteLine(divisao[0]);
            // Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]);
            // Console.WriteLine(divisao[3]);
            // Console.WriteLine(divisao[4]);

            // //var resultado = texto.Substring(5, 5);
            // var resultado = texto.LastIndexOf("o");
            // Console.WriteLine(resultado);

            // Console.WriteLine(texto.Trim());


            //Metodos complementares:

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.ToLower());
            // Console.WriteLine(texto.ToUpper());
            // Console.WriteLine(texto.Insert(5, "AQUI "));
            // Console.WriteLine(texto.Remove(5, 5));
            // Console.WriteLine(texto.Length);


            // Exemplo de Índice:

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.IndexOf("é"));
            // Console.WriteLine(texto.LastIndexOf("s"));

            // Exemplo de Equals:

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.Equals("Este texto é um teste"));
            // Console.WriteLine(texto.Equals("este texto é um teste"));
            // Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

            // Exemplo de StartWith and EndWith:

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.StartsWith("Este"));
            // Console.WriteLine(texto.StartsWith("este"));
            // Console.WriteLine(texto.StartsWith("Texto"));

            // Console.WriteLine(texto.EndsWith("teste"));
            // Console.WriteLine(texto.EndsWith("Teste"));
            // Console.WriteLine(texto.EndsWith("xpro"));

            //Exemplo de Comparação de strings:

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.Contains("teste"));
            // Console.WriteLine(texto.Contains("Teste"));
            // Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine(texto.Contains(null));

        }
    }
}