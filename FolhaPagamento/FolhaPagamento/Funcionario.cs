using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Funcionario
    {
        private string Nome;
        protected string Matricula;
        private int CPF;
        private int Idade;
        private string Email;

        public Funcionario() {
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a matrícula do funcionário: ");
            Matricula = Console.ReadLine();

            Console.Write("Informe o CPF do funcionário: ");
            CPF = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a idade do funcionário: ");
            Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o e-mail do funcionário: ");
            Email = Console.ReadLine();
        }

        protected string getNome()
        {
            return Nome;
        }

        public virtual void displayDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("E-mail: " + Email);
        }

        public virtual double calcularRendimento() {
            return 0;
        }
    }
}
