using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WarnCitizen
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        private const string coronaIncidenceApi = "https://rki.marlon-lueckert.de/api/states";
        private const string citizenApi = "http://localhost:5000/citizen";

        static async Task Main(string[] args)
        {
            //TODO use HttpClient to fetch data from the coronaIncidenceApi(example of the data structure is shown in DataStructureCoronaApi.json) and citizenApi to find the citizens who live in states with an incidences above 50 and warn them
            var response = await client.GetAsync(citizenApi);
            var citizens = await response.Content.ReadAsStringAsync();
            Console.WriteLine(citizens);
            Console.ReadKey();
        }
    }
}
