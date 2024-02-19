namespace ExerciseGuanabara
{
    class Ex27
    {
        public static void Exercise27()
        {
            Console.WriteLine("Digite seu nome: ");
            var name = Console.ReadLine();
            string[] nameArray = name.Split(" ");
            var fname = nameArray[0];
            var lname = nameArray[nameArray.Length - 1];
            Console.WriteLine("Muito prazer em te conhecer!");
            Console.WriteLine($"Seu primeiro nome é {fname} ");
            Console.WriteLine($"Seu último nome é {lname} ");
        }
    }
}