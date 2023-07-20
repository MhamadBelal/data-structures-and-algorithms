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