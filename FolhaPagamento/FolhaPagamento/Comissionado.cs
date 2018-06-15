using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Comissionado : Funcionario
    {
        protected double Comissao;

        public Comissionado()
        {
            Console.Write("Informe o valor da comissão: ");
            Comissao = Convert.ToDouble(Console.ReadLine());
        }

        public override void displayDados()
        {
            base.displayDados();
            Console.WriteLine("Comissão: " + Comissao);
        }

        public override double calcularRendimento()
        {
            return Comissao;
        }
    }
}
