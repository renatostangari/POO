using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Horista : Funcionario
    {
        protected double ValorHora;
        protected int QtdHoras;

        public Horista()
        {
            Console.Write("Informe o valor da hora: ");
            ValorHora = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade de horas: ");
            QtdHoras = Convert.ToInt32(Console.ReadLine());
            
        }

        public override void displayDados()
        {
            base.displayDados();
            Console.WriteLine("Valor da Hora: " + ValorHora);
        }

        public override double calcularRendimento()
        {
            double rendimento = QtdHoras * ValorHora;
            return rendimento;
        }
    }
}
