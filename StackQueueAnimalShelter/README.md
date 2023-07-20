# Stack Queue Animal Shelter

## Whiteboard Process 

![Challenge12(1)](./Assets/Challenge12(1).PNG)
![Challenge12(2)](./Assets/Challenge12(2).PNG)

---

## Approach & Efficiency

The provided code implements an AnimalShelter class that allows animals to be enqueued (added) to the shelter and dequeued (removed) based on the preference of adopting a dog or a cat. The shelter maintains separate queues for dogs and cats, ensuring that animals are dequeued in the order they were enqueued for each species.

**Data Structure**

The implementation uses two Queue<Animal> objects to store dogs and cats separately. The Queue<T> is a first-in-first-out (FIFO) data structure, ensuring that the animals are dequeued in the order they were enqueued.

**Enqueue**

The Enqueue method takes an Animal object as input and enqueues it into the respective queue based on the species (dog or cat). If the species is not "dog" or "cat," an ArgumentException is thrown, indicating that only dogs or cats can be added to the shelter.

The Enqueue method has a time complexity of O(1) because adding an item to a queue takes constant time.

**Dequeue**

The Dequeue method takes a preference ("dog" or "cat") as input and dequeues an animal from the corresponding queue if it is available. If the preferred species queue is empty, it returns null, indicating that no animal of the specified preference is currently available.

The Dequeue method has a time complexity of O(1) for both dogs and cats because dequeuing an item from a queue also takes constant time.

**DogQueueCount & CatQueueCount**

These methods simply return the count of animals in the dog and cat queues, respectively. The time complexity for these methods is also O(1) since counting the number of elements in a queue takes constant time.

**Summary**
Overall, the provided implementation is efficient for both enqueuing and dequeuing animals. Using separate queues for dogs and cats allows the shelter to maintain their respective order without interfering with each other. The time complexity for all operations is O(1), making the solution efficient for handling animal shelters with a large number of animals.

## Solution

Code:

```shell
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge12Code
{
    public class AnimalShelter
    {
        private Queue<Animal> dogQueue;
        private Queue<Animal> catQueue;

        public AnimalShelter()
        {
            dogQueue = new Queue<Animal>();
            catQueue = new Queue<Animal>();
        }

        public void Enqueue(Animal animal)
        {
            if (animal.Species == "dog")
                dogQueue.Enqueue(animal);
            else if (animal.Species == "cat")
                catQueue.Enqueue(animal);
            else
                throw new ArgumentException("Invalid animal species. Must be either 'dog' or 'cat'.");
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "dog")
            {
                if (dogQueue.Count > 0)
                    return dogQueue.Dequeue();
            }
            else if (pref == "cat")
            {
                if (catQueue.Count > 0)
                    return catQueue.Dequeue();
            }

            return null;
        }

        public int DogQueueCount()
        {
            return dogQueue.Count;
        }

        public int CatQueueCount()
        {
            return catQueue.Count;
        }
    }
}

```

Main Funcion and resul:

```shell
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
```

## Test Cases

```shell
using Challenge12Code;

namespace Challenge12Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Enqueue_ShouldAddAnimalToCorrectQueue()
        {
            // Arrange
            var shelter = new AnimalShelter();
            var dog = new Animal("dog", "Buddy");
            var cat = new Animal("cat", "Whiskers");

            // Act
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);

            // Assert
            Assert.Equal(1, shelter.DogQueueCount());
            Assert.Equal(1, shelter.CatQueueCount());
        }

        [Fact]
        public void Dequeue_ShouldReturnCorrectAnimal_BasedOnPreference()
        {
            // Arrange
            var shelter = new AnimalShelter();
            var dog = new Animal("dog", "Buddy");
            var cat = new Animal("cat", "Whiskers");
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);

            // Act
            var firstAnimal = shelter.Dequeue("dog");
            var secondAnimal = shelter.Dequeue("cat");

            // Assert
            Assert.Equal("dog", firstAnimal.Species);
            Assert.Equal("cat", secondAnimal.Species);
            Assert.Equal("Buddy", firstAnimal.Name);
            Assert.Equal("Whiskers", secondAnimal.Name);
        }

        [Fact]
        public void Dequeue_ShouldReturnNull_WhenInvalidPreference()
        {
            // Arrange
            var shelter = new AnimalShelter();
            var dog = new Animal("dog", "Buddy");
            shelter.Enqueue(dog);

            // Act
            var invalidPref = shelter.Dequeue("bird");

            // Assert
            Assert.Null(invalidPref);
        }

        [Fact]
        public void Dequeue_ShouldReturnNull_WhenQueueIsEmpty()
        {
            // Arrange
            var shelter = new AnimalShelter();

            // Act
            var dog = shelter.Dequeue("dog");
            var cat = shelter.Dequeue("cat");

            // Assert
            Assert.Null(dog);
            Assert.Null(cat);
        }
    }
}
```
