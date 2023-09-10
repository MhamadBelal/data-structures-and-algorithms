using SortingObejectCode;

namespace SortingObecjtTest
{
    public class UnitTest1
    {
        [Fact]
        public void CompareByTitle_Should_Sort_Movies_Ignoring_Articles()
        {
            var movies = new List<Movie>
        {
            new Movie { Title = "Game of Thrones", Year = 2008 },
            new Movie { Title = "Pulp Fiction", Year = 1994 },
            new Movie { Title = "Inception", Year = 2010 },
            new Movie { Title = "A Clockwork Orange", Year = 1971 },
            new Movie { Title = "The Shawshank Redemption", Year = 1994 }
        };

            // Sort movies by title using CompareByTitle
            movies.Sort(MovieComparators.CompareByTitle);

            // Assert the expected order after sorting
            Assert.Equal("A Clockwork Orange", movies[0].Title);
            Assert.Equal("Game of Thrones", movies[1].Title);
            Assert.Equal("Inception", movies[2].Title);
            Assert.Equal("Pulp Fiction", movies[3].Title);
            Assert.Equal("The Shawshank Redemption", movies[4].Title);
        }
    }
}