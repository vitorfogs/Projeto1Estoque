using System;
using System.Collections.Generic;
using Projeto_1.produto;

namespace Projeto_1.funcoes
{
    internal class Cadastro
    {
        public static List<IEstoque> Produtos = new List<IEstoque>();
        public static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastro de produtos fisicos: ");
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o frete base: ");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            Produtos.Add(pf);
            Lista.Salvar();
            Console.Clear();

        }

        public static void CadastrarEbook()
        {
            Console.WriteLine("Cadastro de Ebook: ");
            Console.WriteLine("Digite o nome do Ebook: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do autor: ");
            string autor = Console.ReadLine();
            Ebook eb = new Ebook(nome, preco, autor);
            Produtos.Add(eb);
            Lista.Salvar();
            Console.Clear();
        }

        public static void CadastrarCurso()
        {
            Console.WriteLine("Cadastro de Curso: ");
            Console.WriteLine("Digite o nome do Curso: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do autor: ");
            string autor = Console.ReadLine();
            Curso cs = new Curso(nome, preco, autor);
            Produtos.Add(cs);
            Lista.Salvar();
            Console.Clear();
        }
    }
}
