using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.DataPagamento = DateTime.Now;
        }
    }

    class Pagamento
    {
        // Propriedades
        public DateTime MyProperty { get; set; }


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