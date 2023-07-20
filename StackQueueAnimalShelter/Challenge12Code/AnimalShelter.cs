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
