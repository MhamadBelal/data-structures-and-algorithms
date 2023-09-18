using hashmap_repeated_word_Code;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void RepeatedWord_ReturnsFirstRepeatedWord_WhenInputContainsRepeatedWord()
        {
            // Arrange
            string inputString = "It was the best of times, it was the worst of times.";

            // Act
            string result = HashmapRepeatedWord.RepeatedWord(inputString);

            // Assert
            Assert.Equal("it", result, ignoreCase: true); // Ensure case-insensitive comparison
        }

        [Fact]
        public void RepeatedWord_ReturnsNull_WhenInputDoesNotContainRepeatedWord()
        {
            // Arrange
            string inputString = "Once upon a time, there was an excpected brave princess.";

            // Act
            string result = HashmapRepeatedWord.RepeatedWord(inputString);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void RepeatedWord_ReturnsNull_WhenInputIsEmpty()
        {
            // Arrange
            string inputString = string.Empty;

            // Act
            string result = HashmapRepeatedWord.RepeatedWord(inputString);

            // Assert
            Assert.Null(result);
        }
    }
}