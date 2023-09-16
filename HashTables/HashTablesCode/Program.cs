namespace HashTablesCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Hashtable
                // Create a new HashMap with a specified size.
                Hashtable hashMap = new Hashtable(4);

                // Set key-value pairs in the HashMap.
                hashMap.Set("name", "Ahmad");
                hashMap.Set("age", "30");
                hashMap.Set("Kids", "2");

                // Print the contents of the HashMap.
                Console.WriteLine("HashMap Contents:");
                hashMap.Print();
                Console.WriteLine();

                // Test the Get method.
                string name = hashMap.Get("name");
                Console.WriteLine("Name: " + name);

                string profession = hashMap.Get("Major");
                Console.WriteLine("Major: " + profession); // Should print "Profession: null"
                Console.WriteLine();

                // Test the Has method.
                bool hasAge = hashMap.Has("age");
                Console.WriteLine("Has Age: " + hasAge); // Should print "Has Age: True"

                bool hasMajor = hashMap.Has("Major");
                Console.WriteLine("Has Major: " + hasMajor); // Should print "Has Profession: False"

                
            
        }
    }
}