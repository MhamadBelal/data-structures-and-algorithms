using MergeSortCode;

namespace MergeSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void Sort_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] arr = new int[0];

            // Act
            MergeSort.Mergesort(arr);

            // Assert
            Assert.Empty(arr);
        }

        [Fact]
        public void Sort_ArrayWithSingleElement_ReturnsSameArray()
        {
            // Arrange
            int[] arr = { 42 };

            // Act
            MergeSort.Mergesort(arr);

            // Assert
            Assert.Single(arr);
            Assert.Equal(42, arr[0]);
        }

        [Fact]
        public void Sort_SortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.Mergesort(arr);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void Sort_ReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] arr = { 5, 4, 3, 2, 1 };

            // Act
            MergeSort.Mergesort(arr);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void Sort_UnsortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            // Act
            MergeSort.Mergesort(arr);

            // Assert
            Assert.Equal(new[] { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9 }, arr);
        }
    }
}