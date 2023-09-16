using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesCode
{
    public class Hashtable
    {
        // Buckets == a pre determined(size) array
        // The map is an array of linkedlsit of type KeyValuePair


        public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

        public Hashtable(int size)
        {
            Map = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public int Hash(string key)
        {
            int hashValue = 0;

            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i]; /// Integer representation
            }

            //0 - 9
            hashValue = (hashValue * 599) % Map.Length;

            return hashValue;
        }

        public void Set(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] == null)
            {
                Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
            }

            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

            Map[hashKey].Insert(entry);

        }

        public void Print()
        {
            for (int i = 0; i < Map.Length; i++)
            {

                if (Map[i] == null)
                {
                    Console.WriteLine($"Bucket {i}: Empty");
                }

                else
                {
                    Console.WriteLine($"Bucket {i}");

                    Node<KeyValuePair<string, string>> current = Map[i].Head;

                    while (current != null)
                    {
                        Console.Write($"[{current.Value.Key}] : [{current.Value.Value}] =>");

                        current = current.Next;
                    }
                }

            }
        }

        public string Get(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                // Traverse the linked list in the specified bucket.
                Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

                while (current != null)
                {
                    if (current.Value.Key == key)
                    {
                        // Found the key, return its associated value.
                        return current.Value.Value;
                    }

                    current = current.Next;
                }
            }

            // Key not found in the hash map.
            return null; //
        }

        public bool Has(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                // Traverse the linked list in the specified bucket.
                Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

                while (current != null)
                {
                    if (current.Value.Key == key)
                    {
                        // Found the key.
                        return true;
                    }

                    current = current.Next;
                }
            }

            // Key not found in the hash map.
            return false;
        }
    }
}
