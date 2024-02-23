namespace ExerciseGuanabara
{
    class Ex46
    {
        public static void Exercise46()
        {
            var regress = 10;
            for (int i = 0; i < regress; regress--){
                Console.WriteLine(regress);
                Thread.Sleep(500);
            }
            Console.WriteLine("BUM!!! POW!!! POW!!!");
        }
    }
}