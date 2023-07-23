using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge13Code
{
    public class BracketValidator
    {
        private static bool IsMatching(char opening, char closing)
        {
            // Helper function to check if opening and closing brackets match
            return (opening == '(' && closing == ')') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '{' && closing == '}');
        }

        public static bool ValidateBrackets(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || !IsMatching(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }

            // If there are any unmatched opening brackets left in the stack, return false
            return stack.Count == 0;
        }
    }
}
