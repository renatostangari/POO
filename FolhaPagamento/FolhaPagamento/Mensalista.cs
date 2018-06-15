using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Mensalista : Funcionario
    {
        protected double Salario;

        public Mensalista()
        {
            Console.Write("Informe o salário: ");
            Salario = Convert.ToDouble(Console.ReadLine());
        }

        public override void displayDados()
        {
            base.displayDados();
            Console.WriteLine("Salário: " + Salario);
        }

        public override double calcularRendimento()
        {
            return Salario;
        }
    }
}
