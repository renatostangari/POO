using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Empresa
    {
        private string RazaoSocial;
        private string CNPJ;
        private string Endereco;
        private double Faturamento;
        private List<Funcionario> LFuncionario;

        public void cadastrarFuncionario(Funcionario F)
        {
            LFuncionario.Add(F);
        }

        public Empresa()
        {
            LFuncionario = new List<Funcionario>();
            Console.WriteLine("Empresa");
            Console.Write("Informe a Razão Social: ");
            RazaoSocial = Console.ReadLine();
            Console.Write("Informe o CNPJ: ");
            CNPJ = Console.ReadLine();
            Console.Write("Informe o Endereço: ");
            Endereco = Console.ReadLine();
            Console.Write("Informe o Faturamento: ");
            Faturamento = Convert.ToDouble(Console.ReadLine());
            
        }

        public void displayDados()
        {
            foreach(Funcionario z in LFuncionario)
            {
                z.displayDados();
            }
        }

        public void calcularSalarios()
        {
            double Total = 0;
            foreach (Funcionario x in LFuncionario)
            {
                Total = Total + x.calcularRendimento();
            }

            Console.WriteLine("Total: " + Total);
        }
    }
}
