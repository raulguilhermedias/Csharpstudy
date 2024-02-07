using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interpolação de Strings:

            //var texto = "o preço do produto é: " + price + " apenas na promoção!";
            // var texto = string.Format("O preço do produto é: {0} apenas na promoção {1}", price, true);
            var price = 10.2;
            var texto = $"O preço do produto é: \n {price}"; // favorito *

            Console.WriteLine(texto);


            // var id = Guid.NewGuid();
            // id.ToString();

            // id = new Guid("eb2097f0-16a2-42e8-acf0-c8b86426b897");

            // id = new Guid();
            // Console.WriteLine(id.ToString().Substring());

        }
    }
}
