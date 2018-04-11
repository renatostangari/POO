using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaProdutos C1 = new CategoriaProdutos();

            CadastroProdutos P1 = new CadastroProdutos(C1);
            CadastroProdutos P2 = new CadastroProdutos(C1);

            C1.display();
            P1.display();
            P2.display();


            CategoriaProdutos C2 = new CategoriaProdutos();

            CadastroProdutos P3 = new CadastroProdutos(C2);
            CadastroProdutos P4 = new CadastroProdutos(C2);

            C2.display();
            P3.display();
            P4.display();


            CategoriaProdutos C3 = new CategoriaProdutos();

            CadastroProdutos P5 = new CadastroProdutos(C3);
            CadastroProdutos P6 = new CadastroProdutos(C3);

            C3.display();
            P5.display();
            P6.display();

            //categoria c1
            Console.Write("Alterar categoria: ");
            string NovaCategoriac1 = Console.ReadLine();
            C1.setNomeCategoria(NovaCategoriac1);

            //produto p1
            Console.Write("Alterar nome do produto: ");
            string NovoNomep1 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep1);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop1 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop1);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp1 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp1);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep1 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep1);

            //produto p2
            Console.Write("Alterar nome do produto: ");
            string NovoNomep2 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep2);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop2 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop2);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp2 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp2);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep2 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep2);
            
            //categoria c2
            Console.Write("Alterar categoria: ");
            string NovaCategoriac2 = Console.ReadLine();
            C2.setNomeCategoria(NovaCategoriac2);

            //produto p3
            Console.Write("Alterar nome do produto: ");
            string NovoNomep3 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep3);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop3 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop3);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp3 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp3);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep3 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep3);

            //produto p4
            Console.Write("Alterar nome do produto: ");
            string NovoNomep4 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep4);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop4 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop4);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp4 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp4);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep4 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep4);


            //categoria c3
            Console.Write("Alterar categoria: ");
            string NovaCategoriac3 = Console.ReadLine();
            C2.setNomeCategoria(NovaCategoriac3);

            //produto p5
            Console.Write("Alterar nome do produto: ");
            string NovoNomep5 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep5);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop5 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop5);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp5 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp5);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep5 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep5);

            //produto p6
            Console.Write("Alterar nome do produto: ");
            string NovoNomep6 = Console.ReadLine();
            P1.setNomeProduto(NovoNomep6);

            Console.Write("Alterar descrição do produto: ");
            string NovaInfop6 = Console.ReadLine();
            P1.setInfoProduto(NovaInfop6);

            Console.Write("Alterar valor do produto: ");
            double NovoValorp6 = Convert.ToDouble(Console.ReadLine());
            P1.setValorProduto(NovoValorp6);

            Console.Write("Alterar estoque do produto: ");
            int NovoEstoquep6 = Convert.ToInt32(Console.ReadLine());
            P1.setEstoqueProduto(NovoEstoquep6);

            Console.ReadKey();
        }
    }
}
