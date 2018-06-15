using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa E = new Empresa();
            Funcionario F;

            Console.Clear();

            while (true)
            {
                int opcao;

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("[1] - Cadastrar Comissionado");
                Console.WriteLine("[2] - Cadastar Horista");
                Console.WriteLine("[3] - Cadastrar Mensalista");
                Console.WriteLine("[4] - Mostrar Dados");
                Console.WriteLine("[5] - Calcular Rendimento");

                Console.Write("Opcao: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        F = new Comissionado();
                        E.cadastrarFuncionario(F);
                        break;
                    case 2:
                        F = new Horista();
                        E.cadastrarFuncionario(F);
                        break;
                    case 3:
                        F = new Mensalista();
                        E.cadastrarFuncionario(F);
                        break;
                    case 4:
                        E.displayDados();
                        break;
                    case 5:
                        E.calcularSalarios();
                        break;
                    default:
                        Console.WriteLine("Opção incorreta.\n");
                        break;
                }
            }
        }
    }
}
