using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_1.funcoes
{
    internal class Menus
    {
        
        enum Menu1 { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }
        
        public static void Menu()
        {
            Lista.Carregar();
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("sistema de estoque");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saida\n6-Sair");
                string opStr = Console.ReadLine();
                if (int.TryParse(opStr, out int opInt))
                {
                    Menu1 escolha = (Menu1)opInt;

                    if (opInt > 0 && opInt < 7)
                    {
                        Console.Clear();
                        switch (escolha)
                        {
                            case Menu1.Listar:
                                Exibicao.Listagem();
                                Console.WriteLine("Aperte enter para voltar:");
                                Console.ReadLine();
                                break;
                            case Menu1.Adicionar:
                                Adicionar();
                                break;
                            case Menu1.Remover:
                                Exibicao.Remover();
                                break;
                            case Menu1.Entrada:
                                Exibicao.Entrada();
                                break;
                            case Menu1.Saida:
                                Exibicao.Saida();
                                break;
                            case Menu1.Sair:
                                escolheuSair = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("opção Digitata invalida!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        
                    }
                }
                else
                {
                    Console.WriteLine("opção Digitata invalida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                   
                }




                Console.Clear();
            }
        }

        enum Menu2 { ProdutoFisico = 1, Ebook, Curso, Retornar}
        public static void Adicionar()
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Cadastro de produto");
                Console.WriteLine("1-Produto Fisico\n2-Ebook\n3-Curso\n4-Menu inicial");
                string opStr = Console.ReadLine();
                if (int.TryParse(opStr, out int opInt))
                {
                    Menu2 escolha = (Menu2)opInt;
                    if (opInt > 0 && opInt < 5)
                    {
                        Console.Clear();
                        switch (escolha)
                        {
                            case Menu2.ProdutoFisico:
                                Cadastro.CadastrarPFisico();
                                break;
                            case Menu2.Ebook:
                                Cadastro.CadastrarEbook();
                                break;
                            case Menu2.Curso:
                                Cadastro.CadastrarCurso();
                                break;
                            case Menu2.Retornar:
                                escolheuSair = true;
                                break;
                        }

                    }
                    else
                    {
                    Console.WriteLine("opção Digitata invalida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("opção Digitata invalida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }




            }
                
        }
        

    }
}
