namespace ExerciseGuanabara
{
    class Ex45
    {
        public static void Exercise45()
        {

            var jogo = "Pedra Papel Tesoura";
            string[] jokenpo = jogo.Split(" ");
            Console.WriteLine("Bem vindo ao JO KEN PÔ");
            Console.WriteLine("Suas opções: ");
            Console.WriteLine("[1] Pedra");
            Console.WriteLine("[2] Papel");
            Console.WriteLine("[3] Tesoura");
            Console.WriteLine("Qual a opção? ");
            var option = short.Parse(Console.ReadLine());
            Random rng = new Random();
            var Rng = rng.Next(0, jokenpo.Length);
            if (option == 1 && Rng == 0)
            {
                Console.WriteLine($"A Maquina selecionou Tesoura e foi EMPATE jogue novamente...");
                Thread.Sleep(1000);
                Ex45.Exercise45();
            }else if (option == 1 && Rng == 1){
                Console.WriteLine($"A Maquina selecionou Papel e você PERDEU!");
            }else if (option == 1 && Rng == 2){
                Console.WriteLine($"A Maquina selecionou Tesoura e você GANHOU!");
            }else if(option == 2 && Rng == 0)
            {
                Console.WriteLine($"A Maquina selecionou Pedra e você GANHOU!");
            }else if (option == 2 && Rng == 1){
                Console.WriteLine($"A Maquina selecionou Tesoura e foi EMPATE jogue novamente...");
                Thread.Sleep(1000);
                Ex45.Exercise45();
            }else if (option == 2 && Rng == 2){
                Console.WriteLine($"A Maquina selecionou Tesoura e você PERDEU!");
            }else if(option == 3 && Rng == 0)
            {
                Console.WriteLine($"A Maquina selecionou Pedra e você PERDEU!");
            }else if (option == 3 && Rng == 1){
                Console.WriteLine($"A Maquina selecionou Tesoura e você GANHOU!");
            }else if (option == 3 && Rng == 2){
                Console.WriteLine($"A Maquina selecionou Tesoura e foi EMPATE jogue novamente...");
                Thread.Sleep(1000);
                Ex45.Exercise45();
            }
        }
    }
}