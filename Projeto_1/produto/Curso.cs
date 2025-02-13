using System;
using System.Threading;

namespace Projeto_1.produto
{
    [Serializable]
    internal class Curso :Produto,IEstoque
    {
        public string Autor;
        private int _vagas;
        private float _valorVendido;

        public Curso(string nome, float preco, string autor)
        {
            Nome = nome;
            Preco = preco;
            Autor = autor;

        }

        public void AdicionarEntrada()
        {
            Console.Clear();

            Console.WriteLine($"Adicionar entrada no estoque do produto: '{Nome}'");
            Console.WriteLine("Digite a quantidade de vagas que voce quer dar entrada:");
            int entrada;
            bool entradaValida = false;
            while (!entradaValida)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out entrada))
                {
                    _vagas += entrada;
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

            Console.WriteLine($"Consumir vagas do curso: '{Nome}'");
            Console.WriteLine("Digite a quantidade de vagas voce quer consumir:");

            int entrada;
            bool entradaValida = false;
            while (!entradaValida)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out entrada))
                {
                    if (entrada < _vagas)
                    {
                        _vagas -= entrada;
                        _valorVendido = _valorVendido + (entrada * Preco);
                        Console.WriteLine("Saida registrada!");
                        Thread.Sleep(1000);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Numero de vagas acima do total.");
                    }

                }
                else
                {
                    Console.WriteLine("Numero de vagas invalido digite novamente.");
                }
            }
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Vagas restantes: {_vagas}");
            Console.WriteLine($"Vendas até o momento:R${_valorVendido}");
            Console.WriteLine("__________________________");
        }
    }
}
