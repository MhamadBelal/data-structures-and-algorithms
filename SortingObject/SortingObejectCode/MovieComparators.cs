using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingObejectCode
{
    public class MovieComparators
    {
        public static int CompareByYear(Movie a, Movie b)
        {
            // Sort movies by year in descending order (most recent first)
            return b.Year - a.Year;
        }

        public static int CompareByTitle(Movie a, Movie b)
        {
            // Function to remove common articles from movie titles
            string NormalizeTitle(string title)
            {
                title = title.Trim();
            string[] prefixes = { "A ", "An ", "The " };

            foreach (string prefix in prefixes)
            {
                if (title.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    title = title.Substring(prefix.Length).Trim().ToLower();
                    break;
                }
            }

            return title.ToLower();
        }

        return string.Compare(NormalizeTitle(a.Title), NormalizeTitle(b.Title), StringComparison.Ordinal);

    }
}
}
