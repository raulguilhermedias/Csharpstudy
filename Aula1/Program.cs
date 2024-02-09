using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";
        }
    }

    class Pagamento
    {
        // Propriedades
        public DateTime Vencimento;

        // Métodos
        public virtual void Pagar() { }

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/yyyy");
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