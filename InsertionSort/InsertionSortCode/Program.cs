namespace InsertionSortCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = { 8, 4, 23, 42, 16, 15 };
            int[] sampleArray2 = { 20, 18, 12, 8, 5, -2 };
            int[] sampleArray3 = { 5, 12, 7, 5, 5, 7 };

            InsertionSort.InsertionSorting(sampleArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", sampleArray));

            InsertionSort.InsertionSorting(sampleArray2);
            Console.WriteLine("Secend Sorted Array: " + string.Join(", ", sampleArray2));

            InsertionSort.InsertionSorting(sampleArray3);
            Console.WriteLine("third Sorted Array: " + string.Join(", ", sampleArray3));
        }
    }
}