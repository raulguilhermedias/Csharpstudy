using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento();
        }
    }

    class Pagamento
    {
        // Propriedades
        public Pagamento()
        {
            Console.WriteLine("Iniciando o pagamento...");
        }



        // Métodos
        public virtualm prazer te conhecer {}"); void Pagar() 
        {

        }
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

        public override void Pagar()
        {
            base.Pagar();
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;

        public override void Pagar()
        {
            base.Pagar();
        }
    }
}