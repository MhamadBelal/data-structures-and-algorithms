namespace Challenge12Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Animal("dog", "Buddy"));
            shelter.Enqueue(new Animal("cat", "Whiskers"));
            shelter.Enqueue(new Animal("dog", "Max"));

            Animal firstAnimal = shelter.Dequeue("dog"); // Returns the dog named "Buddy"
            Animal secondAnimal = shelter.Dequeue("cat"); // Returns the cat named "Whiskers"
        }
    }
}