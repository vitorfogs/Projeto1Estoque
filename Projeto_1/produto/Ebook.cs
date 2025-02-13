using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_1.produto
{
    [Serializable]
    internal class Ebook:Produto,IEstoque
    {
        public string Autor;
        private int _vendas;
        private float _valorVendido;

        public Ebook(string nome,float preco, string autor)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possivel dar entrada em um Ebook, produto digital.");
            Thread.Sleep(1000);
        }

        public void AdicionarSaida()
        {
            Console.Clear();

            int entrada;
            bool entradaValida = false;
            Console.WriteLine($"Adicionar venda do Ebook: '{Nome}'");
            Console.WriteLine("Digite a quantidade que voce quer vender:");
            while (!entradaValida)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out entrada))
                {
                    _vendas += entrada;
                    _valorVendido = _valorVendido + (entrada * Preco);
                    Console.WriteLine("Venda registrada!");
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    Console.WriteLine("Numero digitado incorreto digite novamente.");
                }
            }
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Vendas: {_vendas}");
            Console.WriteLine($"Vendas até o momento:R${_valorVendido}");
            Console.WriteLine("__________________________");
        }
    }
}
