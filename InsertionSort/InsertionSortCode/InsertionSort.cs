using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortCode
{
    public class InsertionSort
    {
        public static int[] InsertionSorting(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                int value = arry[i];
                int j = i;

                while (j > 0 && value < arry[j - 1])
                {
                    arry[j] = arry[j - 1];
                    j--;
                }

                arry[j] = value;
            }
            return arry;
        }
    }
}
