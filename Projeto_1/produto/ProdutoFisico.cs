using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_1.produto
{
    [Serializable]
    internal class ProdutoFisico : Produto,IEstoque
    {
        public float Frete;
        private int _estoque;
        private float _valorVendido;
        public ProdutoFisico(string nome, float preco,float frete)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.Clear();

            int entrada;
            bool entradaValida = false;
            Console.WriteLine($"Adicionar entrada no estoque do produto: '{Nome}'");
            Console.WriteLine("Digite a quantidade que voce quer dar entrada:");
            while (!entradaValida)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out entrada))
                {
                    _estoque += entrada;
                    Console.WriteLine("Entrada registrada!");
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    Console.WriteLine("entrada invalida digite novamente.");
                }
            }
        }

        public void AdicionarSaida()
        {
            Console.Clear();

            int entrada;
            bool entradaValida = false;
            Console.WriteLine($"Adicionar saida no estoque do produto: '{Nome}'");
            Console.WriteLine("Digite a quantidade que voce quer dar Baixa:");
            while (!entradaValida)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out entrada))
                {
                    _estoque -= entrada;
                    _valorVendido = _valorVendido + (entrada * Preco);
                    Console.WriteLine("Saida registrada!");
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
            Console.WriteLine($"Frete: {Frete}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Estoque: {_estoque}");
            Console.WriteLine($"Vendas até o momento:R${_valorVendido}");
            Console.WriteLine("__________________________");
        }
    }
}
