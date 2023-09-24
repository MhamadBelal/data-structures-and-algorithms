using hashmap_left_joinCode;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void LeftJoin_WithMatchingKeys_ShouldReturnCorrectResult()
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            Assert.Equal(5, result.Count);

            // Check individual rows
            Assert.Equal(new List<string> { "diligent", "employed", "idle" }, result[0]);
            Assert.Equal(new List<string> { "fond", "enamored", "averse" }, result[1]);
            Assert.Equal(new List<string> { "guide", "usher", "follow" }, result[2]);
            Assert.Equal(new List<string> { "outfit", "garb", null }, result[3]);
            Assert.Equal(new List<string> { "wrath", "anger", "delight" }, result[4]);
        }

        [Fact]
        public void LeftJoin_WithNoMatchingKeys_ShouldReturnAllSynonymsWithNullAntonyms()
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "happy", "joyful" },
            { "smart", "intelligent" },
            { "kind", "friendly" }
        };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "sad", "unhappy" },
            { "dumb", "stupid" },
            { "mean", "unfriendly" }
        };

            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            Assert.Equal(3, result.Count);

            // Check individual rows
            Assert.Equal(new List<string> { "happy", "joyful", null }, result[0]);
            Assert.Equal(new List<string> { "smart", "intelligent", null }, result[1]);
            Assert.Equal(new List<string> { "kind", "friendly", null }, result[2]);
        }

        [Fact]
        public void LeftJoin_WithNoSynonyms_ShouldReturnAllKeysWithNullValues()
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "up", "down" },
            { "left", "right" },
            { "yes", "no" }
        };

            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            Assert.Equal(0, result.Count);
        }
    }
}