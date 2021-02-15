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
    }
}

