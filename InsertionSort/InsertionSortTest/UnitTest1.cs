using Xunit;
using InsertionSortCode;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { 8, 4, 23, 42, 16, 15 })]
        [InlineData(new[] { 20, 18, 12, 8, 5, -2 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 })]
        [InlineData(new[] { 2, 3, 5, 7, 13, 11 })]
        public void TestArrayIsSorted(int[] inputArray)
        {
            int[] sortedArray = InsertionSortCode.InsertionSort.InsertionSorting(inputArray);
            Assert.True(IsArraySorted(sortedArray));
        }

        public bool IsArraySorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}