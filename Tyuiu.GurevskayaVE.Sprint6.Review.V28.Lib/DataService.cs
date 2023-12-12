using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GurevskayaVE.Sprint6.Review.V28.Lib
{
    public class DataService
    {
        public double GetMatrix(in int[,] array, int n1, int n2, int k, int l, int r)
        {
            int n = array.GetLength(0);
            int m = array.Length / n;

            // input validity
            if (n <= 1 || m <= 1 || n1 >= n2 || k >= l || r >= n)
            {
                return 0.0;
            }

            double result = 0;

            for (int i = 0; i < n; i++) // rows
            {
                for (int j = 0; j < m; j++) // columns
                {
                    if (i == r && (j >= k && j <= l)) // exclude
                    {
                        continue;
                    }

                    result += array[i, j];
                }
            }

            return Math.Round(result / (n * m - (l - k + 1)), 3);


        }
        
    }
}
