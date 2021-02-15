using System;
using System.Collections.Generic;
using System.Text;

namespace BlogsSort
{
    public class Insert
    {
        public int[] InsertionSort(int[] arr)
        {         //we are defining the method which takes in an int array as its params.
            int n = arr.Length;                        //we are declaring n as an integer, assigning the arr.length to be its size
            for (int i = 0; i < n; i++)
            {                                          //we are creating a for loop utilizing i, which is continually checked against the size of n
                int min = i;                           //declaring a new integer of "min" which is assigned to i
                for (int j = i + 1; j < n; j++)
                {                                       //create a for loop, assigning j to i + 1. (j starts one ahead of i) which is then checked against the length of n
                    if (arr[j] < arr[min])              //if statement, if J's index is smaller than min's index, do next.
                        min = j;                        //then min becomes J
                }
                int temp = arr[min];                   //Declaring integer temp, assigning it to min's index.
                arr[min] = arr[i];                     //we are re-assigning min's index to i's index
                arr[i] = temp;                         //we are re-assigning i's index to temp's value
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            return arr;
        }
    }
}
