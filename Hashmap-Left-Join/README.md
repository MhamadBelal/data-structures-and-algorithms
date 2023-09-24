# Hashmap Left Join

## Whiteboard Process 

![Hashmap Left Join 1](./Assets/Challenge33(1).PNG)
![Hashmap Left Join 2](./Assets/Challenge33(2).PNG)

---

## Approach & Efficiency

**Approach:**
The LeftJoin function performs a left join operation on two dictionaries, synonyms and antonyms, and returns the result as a list of lists. Here's an overview of the approach:

1. Initialize an empty list result to store the final result.

2. Iterate through each key-value pair in the synonyms dictionary:

* For each key, get the synonym value.
* Check if the key exists in the antonyms dictionary.
* If it exists, get the corresponding antonym value; otherwise, set it to null.
* Create a list row containing three elements: key, synonym value, and antonym value.
* Append row to the result list.

3. After iterating through all key-value pairs in the synonyms dictionary, return the result list.

**Efficiency:**

Time Complexity: The time complexity of this approach is O(n), where n is the number of key-value pairs in the synonyms dictionary. This is because we iterate through all keys in the synonyms dictionary exactly once, and each dictionary lookup operation (antonyms.ContainsKey(key)) has an average time complexity of O(1).

Space Complexity: The space complexity of this approach is also O(n). The primary space usage comes from the result list, which contains lists with three string elements each. The size of the result list is directly proportional to the number of key-value pairs in the synonyms dictionary.

Overall, this implementation is efficient and linear in terms of time complexity, making it suitable for processing dictionaries with a large number of entries.

---

## Solution

Function Code:

```shell
public static List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = new List<List<string>>();

            foreach (var kvp in synonyms)
            {
                string key = kvp.Key;
                string synonymValue = kvp.Value;
                string antonymValue = antonyms.ContainsKey(key) ? antonyms[key] : null;

                List<string> row = new List<string>
            {
                key,
                synonymValue,
                antonymValue
            };

                result.Add(row);
            }

            return result;
        }
```

Main Function Code:

```shell
static void Main(string[] args)
        {

            // Test cases
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

            List<List<string>> result = LeftJoin(synonyms, antonyms);

            // Print the result
            foreach (var row in result)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }

            Console.ReadKey();
        }
```

---

## Test Cases

```shell
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
```
