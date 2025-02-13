using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Projeto_1.produto;

namespace Projeto_1.funcoes
{
    internal class Lista
    {
        public static void Salvar()
        {
            FileStream stream = new FileStream("Produtos.dat",FileMode.OpenOrCreate);
            BinaryFormatter encoder  = new BinaryFormatter();

            encoder.Serialize(stream, Cadastro.Produtos);
            stream.Close();

        }
        public static void Carregar()
        {
            FileStream stream = new FileStream("Produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            try
            {
                Cadastro.Produtos = (List<IEstoque>)encoder.Deserialize(stream);

                if(Cadastro.Produtos == null)
                {
                    Cadastro.Produtos = new List<IEstoque>();
                }
            }
            catch 
            { 
                Cadastro.Produtos = new List<IEstoque>();
            }
            stream.Close();
        }
    }
}
