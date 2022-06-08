using System;
using System.Collections.Generic;
using System.Globalization;


namespace ListaProduto
{
    class Program
    {
        static List<Produto> produtos;
        static void Main(string[] args)
        {
            produtos = new List<Produto>();
            produtos.Add(new Produto("Notethinkpad", 10000));
            produtos.Add(new Produto("Macbook", 17000));
            produtos.Add(new Produto("Mouse Logitech", 125));
            produtos.Add(new Produto("Teclado Logitech", 150));
            produtos.Add(new Produto("Monitor Thinkpad", 1500));
            produtos.Add(new Produto("Mouse Pad", 100));
            produtos.Add(new Produto("WebCam", 120));
            produtos.Add(new Produto("HeadSet", 250));
            produtos.Add(new Produto("Kit teclado mouse Logitech", 255));
            produtos.Add(new Produto("Suporte notebook", 110));

            Console.WriteLine(">>> Lista dos itens: <<<");

            foreach (Produto list in produtos)
            {
                Console.WriteLine(list.Nome + " - " + "{0:F2}", list.Preco, CultureInfo.InvariantCulture);
            }

            Console.WriteLine("");
            Console.WriteLine(">>> Lista Ordenada por Preço: <<<");
            produtos.Sort(delegate (Produto p1, Produto p2)
            {
                return p1.Preco.CompareTo(p2.Preco);
            });
            produtos.ForEach(delegate (Produto p)
            {
                Console.WriteLine(String.Format("{0} - {1:F2}", p.Nome, p.Preco, CultureInfo.InvariantCulture));
            });
            produtos.Reverse(0, 9);
            Console.WriteLine("");

            int indice = produtos.FindIndex(x => x.Nome == "Mouse Logitech");
            if (indice != -1)
            {
                Console.WriteLine($"O produto Mouse Logitech se encontra na posição {indice} da lista");
            }
            else
            {
                Console.WriteLine("O produto Mouse Logitech não se encontra na lista!");
            }

            Console.WriteLine("\n>>> Inserindo um produto na posição 5 <<<");
            produtos.Insert(4, new Produto() { Nome = "Carregador", Preco = 270 });
            foreach (Produto list in produtos)
            {
                Console.WriteLine(list.Nome + " - " + "{0:F2}", list.Preco, CultureInfo.InvariantCulture);
            }
            Console.WriteLine("\n>>> Inserindo um produto no final da lista <<<");
            produtos.Insert(11, new Produto() { Nome = "Apoio para os pes", Preco = 352 });
            foreach (Produto list in produtos)
            {
                Console.WriteLine(list.Nome + " - " + "{0:F2}", list.Preco, CultureInfo.InvariantCulture);
            }
            Console.Write("\nQuantidade de produtos na lista: " + produtos.Count);

            /*produtos.FindAll(x => x[0] == 'A');
            foreach (string list in produtos)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("Produtos que comecam com A: " + letraA)*/

            Console.WriteLine("\n\n>>> Removendo produto na posicao 8 <<< ");
            produtos.RemoveAt(7);
            foreach (Produto list in produtos)
            {
                Console.WriteLine(list.Nome + " - " + "{0:F2}", list.Preco, CultureInfo.InvariantCulture);
            }
            Console.ReadLine();

        }
    }
}
