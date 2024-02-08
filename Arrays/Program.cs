using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario(){Id = 2579, Name = "André"};

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Name);
            }
            // for (var index = 0; index < meuArray.Length; index++)
            // {
            //     Console.WriteLine(meuArray[index]);
            // }
        }
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
