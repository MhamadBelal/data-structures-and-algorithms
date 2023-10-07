using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Business_TripCode
{
    public class Graph
    {
        private Dictionary<string, Dictionary<string, int>> flights;

        public Graph()
        {
            flights = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AddDirectFlight(string city1, string city2, int cost)
        {
            if (!flights.ContainsKey(city1))
            {
                flights[city1] = new Dictionary<string, int>();
            }

            flights[city1][city2] = cost;
        }

        public bool HasDirectFlight(string city1, string city2)
        {
            return flights.ContainsKey(city1) && flights[city1].ContainsKey(city2);
        }

        public int GetDirectFlightCost(string city1, string city2)
        {
            return flights[city1][city2];
        }
    }

    public static class BusinessTrip
    {
        public static int? CalculateTripCost(Graph graph, string[] cities)
        {
            if (cities == null || cities.Length < 2)
            {
                return null;
            }

            int totalCost = 0;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                string currentCity = cities[i];
                string nextCity = cities[i + 1];

                if (!graph.HasDirectFlight(currentCity, nextCity))
                {
                    return null;
                }

                totalCost += graph.GetDirectFlightCost(currentCity, nextCity);
            }

            return totalCost;
        }
    }
}
