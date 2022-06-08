using System;
using System.Collections.Generic;
using ListaProduto;

namespace SwitchCaseExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>() {
            new Produto("Notethinkpad", 10000),
            new Produto("Macbook", 17000),
            new Produto("Mouse Logitech", 125),
            new Produto("Teclado Logitech", 150),
            new Produto("Monitor Thinkpad", 1500),
            new Produto("Mouse Pad", 100),
            new Produto("WebCam", 120),
            new Produto("HeadSet", 250),
            new Produto("Kit teclado mouse Logitech", 255),
            new Produto("Suporte notebook", 110),
        };

            Console.WriteLine("Digite a opção que deseja: ");
            var valores = int.Parse(Console.ReadLine());
            switch (valores)
            {
                case 1:
                    Console.WriteLine(produtos[0]);
                    break;

                case 2:
                    Console.WriteLine(produtos[1]);
                    break;

                case 3:
                    Console.WriteLine(produtos[2]);

                    break;
                case 4:
                    Console.WriteLine(produtos[3]);

                    break;
                case 5:
                    Console.WriteLine(produtos[4]);
                    break;
                default:
                    Console.WriteLine("Não foi possível consultar a lista!");
                    break;
            }
        }
    }
}