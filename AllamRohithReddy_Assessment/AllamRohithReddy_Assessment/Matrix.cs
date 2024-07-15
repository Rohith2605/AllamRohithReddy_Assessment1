using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllamRohithReddy_Assessment
{
    internal class Matrix
    {
       
        public void Display(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 }, { 4, 5, 6 } };
            Matrix m = new Matrix();
            m.Display(matrix);
        }
      
    }
}
