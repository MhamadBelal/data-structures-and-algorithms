namespace Challenge13Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BracketValidator.ValidateBrackets("{}"));  // Output: True
            Console.WriteLine(BracketValidator.ValidateBrackets("{}(){}"));  // Output: True
            Console.WriteLine(BracketValidator.ValidateBrackets("()[[Extra Characters]]"));  // Output: True
            Console.WriteLine(BracketValidator.ValidateBrackets("(){}[[]]"));  // Output: True
            Console.WriteLine(BracketValidator.ValidateBrackets("{}{Code}[Fellows](())"));  // Output: True
            Console.WriteLine(BracketValidator.ValidateBrackets("[({}]"));  // Output: False
            Console.WriteLine(BracketValidator.ValidateBrackets("(]"));  // Output: False
            Console.WriteLine(BracketValidator.ValidateBrackets("{(})"));  // Output: False
        }
    }
}