namespace Graph_Business_TripCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            // Adding direct flights and their costs
            graph.AddDirectFlight("Metroville", "Pandora", 82);
            graph.AddDirectFlight("Arendelle", "New Monstropolis", 23);
            graph.AddDirectFlight("New Monstropolis", "Naboo", 92);

            // Test 1: Possible trip with direct flights
            int? result1 = BusinessTrip.CalculateTripCost(graph, new string[] { "Metroville", "Pandora" });
            Console.WriteLine(result1); // Output: 82

            // Test 2: Possible trip with direct flights
            int? result2 = BusinessTrip.CalculateTripCost(graph, new string[] { "Arendelle", "New Monstropolis", "Naboo" });
            Console.WriteLine(result2); // Output: 115

            // Test 3: Trip not possible (no direct flight between Naboo and Pandora)
            int? result3 = BusinessTrip.CalculateTripCost(graph, new string[] { "Naboo", "Pandora" });
            Console.WriteLine(result3); // Output: null

            // Test 4: Trip not possible (no direct flight between Narnia and Arendelle)
            int? result4 = BusinessTrip.CalculateTripCost(graph, new string[] { "Narnia", "Arendelle", "Naboo" });
            Console.WriteLine(result4); // Output: null

            Console.ReadKey();
        }
    }
}