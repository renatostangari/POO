using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoMercado
{
    class CadastroProdutos
    {
        private string NomeProduto;
        private string InfoProduto;
        private int EstoqueProduto;
        private double ValorProduto;
        private CategoriaProdutos CategoriaProdutos;

        public CadastroProdutos(CategoriaProdutos CategoriaProdutos)
        {
            this.CategoriaProdutos = CategoriaProdutos;
            Console.Write("Informe o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write("Informe a descrição do produto: ");
            InfoProduto = Console.ReadLine();
            Console.Write("Informe o valor do produto: ");
            ValorProduto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade em estoque: ");
            EstoqueProduto = Convert.ToInt32(Console.ReadLine());
        }
        public CategoriaProdutos getCategoriaProdutos()
        {
            return CategoriaProdutos;
        }

        public string getNomeProduto()
        {
            return NomeProduto;
        }

        public string getInfoProduto()
        {
            return InfoProduto;
        }

        public double getValorProduto()
        {
            return ValorProduto;
        }

        public int getEstoqueProduto()
        {
            return EstoqueProduto;
        }
        

        public void setNomeProduto(string NomeProduto)
        {
            this.NomeProduto = NomeProduto;
        }

        public void setInfoProduto(string InfoProduto)
        {
            this.InfoProduto = InfoProduto;
        }

        public void setValorProduto(double ValorProduto)
        {
            this.ValorProduto = ValorProduto;
        }
        public void setEstoqueProduto(int EstoqueProduto)
        {
            this.EstoqueProduto = EstoqueProduto;
        }
        
        
        public void display()
        {
            Console.WriteLine("Produto: " + NomeProduto);
            Console.WriteLine("Descrição: " + InfoProduto);
            Console.WriteLine("Valor: " + ValorProduto);
            Console.WriteLine("Estoque: " + EstoqueProduto);

        }
    }
}
    

