# Merge Sort Blog
The Mergesort method will take an array and sort the values in ascending order like insert sort. However, merge sort breaks everything down.


### How does it work?
Initially our array is iterated over and the middle is found, the middle here is 1. Then the array is split into a left and right arrays based off the middle.

The left array is iterated and split as well, first splitting 8 nad -1. Then we still have multiple values of 1 and 21, so they are split too.

The steps above are done recursively with the right array as well.

Once everything is split, we start to compare and merge things back together. The values that were split will compare their values, then place themselves in the correct order. So once we have [-1, 8] and [1, 21] properly ordered, they will now compare each other again!

We now have a left and right array that are both sorted properly. Lastly, the left and right will compare values and merge them together. Resulting in a sorted array.

### Efficiency and time

- The space efficiency is O(n)
    - This is a comparison operation, we are just sorting and array then returnign it.
    
- The time efficiency is O(n log n)
    - Mergesort has a very bad time efficiency due to the required copying of the collection.
