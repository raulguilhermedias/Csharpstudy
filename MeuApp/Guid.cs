using System;

namespace Guid
{
    class Program{
        
        static void Main(string[] args){
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }
    }
}