using BlogsSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertSort()
        {
            //tests are passing, but I can't push to github.
            int[] lostNumber = { 8, 4, 23, 42, 16, 15 };
            Insert insertSort = new Insert();
            int[] fromInsertSort = insertSort.InsertionSort(lostNumber);
            int[] correctNumber = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(correctNumber.ToString(), fromInsertSort.ToString());
        }

        [Fact]
        public void TestMergeSort()
        {
            int[] actual = { 8, 4, 23, 42, 16, 15 };
            int[] expected = { 4, 8, 15, 16, 23, 42 };

            int[] actualTwo = { 3, 51, 23, 44, 1, 0, 22, 99 };
            int[] expectedTwo = { 0, 1, 3, 22, 23, 44, 51, 99 };
            Merge mergeSort = new Merge();

            mergeSort.mergeSorter(actual);
            mergeSort.mergeSorter(actualTwo);

            Assert.Equal(expected.ToString(), actual.ToString());
            Assert.Equal(expectedTwo.ToString(), actualTwo.ToString());
        }
    }
}

