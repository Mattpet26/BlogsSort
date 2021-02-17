# Quick Sort 
- The QuickSort method will take an array and sort the values in ascending order, it is more efficient than insert/merge sort with larger arrays.
- A swap method is written to swap the values when the left > right. Values are saved as a "temp" so we don't lose their value in the swap.
- The partition method is utilized once the quickSort has checked that there is no value greater than the middle. So if we have numbers 1-10, once 5 has checked that it is greater than 1-4 and less than 6-10 the array is "split" into two. 
- The split mentioned above is not literal.

#Efficiency
- Time efficiency is: O(log n)
 
- Space efficiency is: O(n)
    - There is no additional space created, numbers are all swapped in place.
    
#How does it work? (briefly)
- Values are compared with a left / right. Left is 0th index and right is the last index. 
- The left and right check each others values. If left is less than right, the new right is - 1 index.
    - We continue this step until a value is less than the left, when this happens they swap. 
    - The initial left value is called "pivot"
    - The left now moves its index +1 and compares the new left's value to the pivot.
    - These steps continue until the rest of the numbers have been checked. Everything to the left of the pivot is now partitioned. 
- Now the partitioned indexes will check their values, swapping when left > right.
    - There is a left partitioned side and a right. Each side will do the step mentioned above.
- After the partitioned left and right have completed their swaps, they are then all placed back together.
- Everything will be in ascending order now.



