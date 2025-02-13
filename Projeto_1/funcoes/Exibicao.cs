using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Projeto_1.produto;

namespace Projeto_1.funcoes
{
    internal class Exibicao
    {
        public static void Listagem()
        {
            if (Cadastro.Produtos.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
                Thread.Sleep(1000);

                return;
            }
            Console.WriteLine("Lista de Produtos");
            int i = 0;
            foreach(IEstoque produto in Cadastro.Produtos)
            {
                Console.WriteLine($"ID: {i}");
                produto.Exibir();
                i++;
            }
        }

        public static void Remover()
        {
            if (Cadastro.Produtos.Count == 0)
            {
                Console.WriteLine("A lista está vazia. Não há itens para remover.");
                Thread.Sleep(1000);

                return;
            }
            Listagem();
            int id;
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.WriteLine("Digite o ID do elemento que deseja remover (ou digite 'sair' para cancelar): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sair")
                {
                    Console.WriteLine("Operação cancelada pelo usuário.");
                    return;
                }
                if (int.TryParse(input, out id))
                {
                    if (id >= 0 && id < Cadastro.Produtos.Count)
                    {
                        Cadastro.Produtos.RemoveAt(id);
                        Lista.Salvar();
                        Console.WriteLine("Elemento removido com sucesso!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("ID inválido. O ID deve estar entre 0 e " + (Cadastro.Produtos.Count - 1) + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
            }

        }
        public static void Entrada()
        {
            Listagem();
            int id;
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.WriteLine("Digite o ID do elemento que deseja dar entrada: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out id))
                {

                    if (id >= 0 && id < Cadastro.Produtos.Count)
                    {
                        Cadastro.Produtos[id].AdicionarEntrada();
                        Lista.Salvar();
                        if (Cadastro.Produtos[id] is Ebook)
                        {
                            return;
                        }
                        Console.WriteLine("Entrada registrada com sucesso!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("ID inválido. O ID deve estar entre 0 e " + (Cadastro.Produtos.Count - 1) + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
            }
        }
        public static void Saida()
        {
            Listagem();
            int id;
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.WriteLine("Digite o ID do elemento que deseja dar saida: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out id))
                {
                    if (id >= 0 && id < Cadastro.Produtos.Count)
                    {
                        Cadastro.Produtos[id].AdicionarSaida();
                        Lista.Salvar();
                        Console.WriteLine("Saída registrada com sucesso!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("ID inválido. O ID deve estar entre 0 e " + (Cadastro.Produtos.Count - 1) + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
            }
        }
    }
}
