namespace hashmap_left_joinCode
{
    public class Program
    {
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
    }
}