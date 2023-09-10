namespace SortingObejectCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
        {
            new Movie { Title = "Game of Thrones", Year = 2008 },
            new Movie { Title = "Pulp Fiction", Year = 1994 },
            new Movie { Title = "Inception", Year = 2010 },
            new Movie { Title = "A Clockwork Orange", Year = 1971 },
            new Movie { Title = "The Shawshank Redemption", Year = 1994 }
        };

            // Sort movies by year using CompareByYear
            movies.Sort(MovieComparators.CompareByYear);

            Console.WriteLine("Movies sorted by year (most recent first):");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
            }

            Console.WriteLine();

            // Sort movies by title using CompareByTitle
            movies.Sort(MovieComparators.CompareByTitle);

            Console.WriteLine("Movies sorted by title:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
            }
        }
    }
}