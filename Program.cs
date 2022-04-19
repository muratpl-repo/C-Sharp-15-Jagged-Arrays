using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56DuzensizKonumlanmisDiziler //Jagged Arrays - Puruzlu Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] sayilar = { { 2, 3 }, { 4 } };                                //Bu sekilde yazilamayacagi icin bi dizinin icine atiyoruz.
            int[][] sayilar = new int[2][] { new int[] { 2, 3 }, new int[] { 4 } };
            //int[][] sayilar = { { new int[] { 2, 3 } }, { new int[] { 4 } } };   //Usttekinin farkli gosterimi

            //Console.WriteLine(sayilar[1][0]);

            int[][,] sayilar2 = new int[3][,] { new int[,] { { 2, 3 }, { 3, 4 } },
                                                new int[,] { { 4 }, { 5 } },
                                                new int[,] { { 1, 2, 3 }, { 4, 5, 6 } } };
            Console.WriteLine(sayilar2[2][0, 1]);
        }
    }
}

