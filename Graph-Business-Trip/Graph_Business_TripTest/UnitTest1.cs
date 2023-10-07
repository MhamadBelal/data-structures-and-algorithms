using Graph_Business_TripCode;

namespace Graph_Business_TripTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPossibleTripWithDirectFlights()
        {
            Graph graph = new Graph();
            graph.AddDirectFlight("Metroville", "Pandora", 82);
            graph.AddDirectFlight("Arendelle", "New Monstropolis", 23);
            graph.AddDirectFlight("New Monstropolis", "Naboo", 92);

            int? result = BusinessTrip.CalculateTripCost(graph, new string[] { "Metroville", "Pandora" });
            Assert.Equal(82, result);
        }

        [Fact]
        public void TestPossibleTripWithDirectFlights_MultipleCities()
        {
            Graph graph = new Graph();
            graph.AddDirectFlight("Metroville", "Pandora", 82);
            graph.AddDirectFlight("Arendelle", "New Monstropolis", 23);
            graph.AddDirectFlight("New Monstropolis", "Naboo", 92);

            int? result = BusinessTrip.CalculateTripCost(graph, new string[] { "Arendelle", "New Monstropolis", "Naboo" });
            Assert.Equal(115, result);
        }

        [Fact]
        public void TestTripNotPossible_NoDirectFlight()
        {
            Graph graph = new Graph();
            graph.AddDirectFlight("Metroville", "Pandora", 82);
            graph.AddDirectFlight("Arendelle", "New Monstropolis", 23);

            int? result = BusinessTrip.CalculateTripCost(graph, new string[] { "Naboo", "Pandora" });
            Assert.Null(result);
        }

        [Fact]
        public void TestTripNotPossible_SingleCity()
        {
            Graph graph = new Graph();
            graph.AddDirectFlight("Metroville", "Pandora", 82);

            int? result = BusinessTrip.CalculateTripCost(graph, new string[] { "Metroville" });
            Assert.Null(result);
        }

        [Fact]
        public void TestTripNotPossible_EmptyCitiesArray()
        {
            Graph graph = new Graph();

            int? result = BusinessTrip.CalculateTripCost(graph, new string[] { });
            Assert.Null(result);
        }

        [Fact]
        public void TestTripNotPossible_NullCitiesArray()
        {
            Graph graph = new Graph();

            int? result = BusinessTrip.CalculateTripCost(graph, null);
            Assert.Null(result);
        }
    }
}