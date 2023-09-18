using System;

namespace hashmap_repeated_word_Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(HashmapRepeatedWord.RepeatedWord("Once upon a time, there was a brave princess who...")); // Output: "a"
            Console.WriteLine(HashmapRepeatedWord.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness...")); // Output: "it"
            Console.WriteLine(HashmapRepeatedWord.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs...")); // Output: "summer"
        }
    }
}