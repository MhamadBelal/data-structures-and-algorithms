using Challenge13Code;

namespace Challenege13Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidBrackets()
        {
            // Happy Path - Expected outcome
            Assert.True(BracketValidator.ValidateBrackets("{}"));
            Assert.True(BracketValidator.ValidateBrackets("{}(){}"));
            Assert.True(BracketValidator.ValidateBrackets("()[[Extra Characters]]"));
            Assert.True(BracketValidator.ValidateBrackets("(){}[[]]"));
            Assert.True(BracketValidator.ValidateBrackets("{}{Code}[Fellows](())"));
        }

        [Fact]
        public void TestInvalidBrackets()
        {
            // Expected failure
            Assert.False(BracketValidator.ValidateBrackets("[({}]"));
            Assert.False(BracketValidator.ValidateBrackets("(]"));
            Assert.False(BracketValidator.ValidateBrackets("{(})"));
        }

        [Fact]
        public void TestEdgeCase()
        {
            // Edge Case: Empty string should be considered balanced
            Assert.True(BracketValidator.ValidateBrackets(""));

            // Edge Case: Single type of bracket should be considered unbalanced
            Assert.False(BracketValidator.ValidateBrackets("(((((("));
        }
    }
}