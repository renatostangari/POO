using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoMercado
{
    class CategoriaProdutos
    {
        private string NomeCategoria;

        public CategoriaProdutos()
        {
            Console.Write("Informe a categoria do produto: ");
            NomeCategoria = Console.ReadLine();
        }

        public string getNomeCategoria()
        {
            return NomeCategoria;
        }
        public void setNomeCategoria(string NomeCategoria)
        {
            this.NomeCategoria = NomeCategoria;
        }
        public void display()
        {
            Console.WriteLine("Categoria: " + NomeCategoria);
        }
    }
}
