using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortCode
{
    public class MergeSort
    {
        public static void Mergesort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;

                int[] left = new int[mid];
                int[] right = new int[n - mid];

                // Fill left and right arrays
                for (int i = 0; i < mid; i++)
                    left[i] = arr[i];

                for (int i = mid; i < n; i++)
                    right[i - mid] = arr[i];

                // Recursively sort left and right arrays
                Mergesort(left);
                Mergesort(right);

                // Merge left and right arrays back into arr
                Merge(left, right, arr);
            }
        }

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
