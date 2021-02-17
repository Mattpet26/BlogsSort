using System;
using System.Collections.Generic;
using System.Text;

namespace BlogsSort
{
    public class Quick
    {
        public void quickSort(int[] arr, int left, int right)
        {
            Console.WriteLine(arr.ToString());
            if (left < right)
            {
                int position = partition(arr, left, right);
                quickSort(arr, left, position - 1);
                quickSort(arr, position + 1, right);
            }
        }
        public int partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                Console.WriteLine(arr.ToString());
                if (arr[i] <= pivot)
                {
                    low++;
                    swap(arr, i, low);
                }
            }
            swap(arr, right, low + 1);
            return low + 1;
        }
        public int swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
            Console.WriteLine("swap");
            return temp;
        }
    }
}
