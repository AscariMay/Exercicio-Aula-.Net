using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 2;
            matriz[0, 1] = 10;
            matriz[1, 1] = 0;
            matriz[1, 2] = 3;
            matriz[2, 1] = 1;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.WriteLine(matriz [i,j] + " ");
                }
            Console.ReadLine();
            }
            int somaLinha = matriz[0, 0] + matriz[0, 1] + matriz[0, 2];
            Console.WriteLine($"Soma da linha = {somaLinha}");
            Console.WriteLine("");
            int somaColuna = matriz[1, 0] + matriz[1, 1] + matriz[2, 1];
            Console.WriteLine($"Soma da coluna = {somaColuna}");
            Console.WriteLine("");
            int multiplicacao = ((matriz[0, 1]) * (matriz[1, 0]) + matriz[1, 1] + matriz[1, 2]) * (matriz[0, 2] + matriz[1, 2] + matriz [2, 2]);
            Console.WriteLine($"Soma da coluna = {multiplicacao}");

        }
    }
}
