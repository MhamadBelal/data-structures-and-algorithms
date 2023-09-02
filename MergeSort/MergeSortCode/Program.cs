namespace MergeSortCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", arr));

            MergeSort.Mergesort(arr);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}