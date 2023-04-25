using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi visocina: ");
            int h = int.Parse(Console.ReadLine());
            long[][] triangle = new long[h + 1][];

            for (int row = 0; row < h; row++)
            {
                triangle[row] = new long[row + 1];

            }
            triangle[0][0] = 1;
            for (int row = 0; row < h - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                    Console.Write(triangle[row][col]);
                }
                //Console.WriteLine();
            }
            for (int row = 0; row < h; row++)
            {
                for (int space = 0; space < h - row - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{triangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
 }
