using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_em_C_ {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int M, N;

            Console.Write("Quantas linhas vai ter a matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter a matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N]; ///int[,] Definir matriz em mais dimensões

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");
            for(int i = 0;i < M; i++) {
                for(int j = 0;j < N; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
