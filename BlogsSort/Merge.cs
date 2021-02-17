using System;
using System.Collections.Generic;
using System.Text;

namespace BlogsSort
{
    public class Merge
    {
        public void mergeSorter(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = arr[i];
                    Console.WriteLine(arr.ToString());
                }
                int[] right = new int[n - mid];
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = arr[mid];
                    mid = mid + 1;
                    Console.WriteLine(arr.ToString());
                }
                mergeSorter(left);
                mergeSorter(right);
                merge(left, right, arr);
            }
            Console.WriteLine(arr.ToString());
        }
        public void merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            if (i < left.Length)
            {
                arr[k] = left[i];
                i = i + 1;
            }
            else
            {
                arr[k] = right[j];
                j = j + 1;
            }
        }
    }
}
