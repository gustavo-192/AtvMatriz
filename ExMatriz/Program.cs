using System;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas
            por N colunas contendo números inteiros, podendo haver repetições. Em seguida, ler um número
            inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima,
            à direita e abaixo de X, quado houver, conforme exemplo.*/

            Console.Write("Digite a quantidade de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os valores da Matriz: ");
                string[] values = Console.ReadLine().Split(' '); 
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n;j++)
                {
                    Console.Write(mat[i,j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite um número que pertence a matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i,j])
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " +  mat[i, j - 1]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i , j + 1]);
                        }
                        if (i < m -1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }              
                }
            }
            //Gustavo Trajano Costa EX MATRIZ
        }
    }
}
