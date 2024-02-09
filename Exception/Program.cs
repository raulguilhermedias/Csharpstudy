﻿using System;
using System.Runtime.CompilerServices;

namespace Execption
{
    public class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[3];
            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice da lista");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops deu errado!");
            }

        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new Exception("o texto não pode ser nulo ou vazio");
            }
        }
    }
}