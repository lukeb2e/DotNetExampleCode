using System;
using System.Net.Http;

namespace WarnCitizen
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string coronaIncidenceApi = "https://rki.marlon-lueckert.de/api/states";
        static readonly string citizenApi = "http://localhost:5000/citizen";
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //TODO use HttpClient to fetch data from the coronaIncidenceApi(example of the properties are found in the CoronaApi json)  and citizenApi to find the citizen who live in states with an index above 50 and warn them
            Console.WriteLine("TODO");
            Console.ReadKey();
        }
    }
}
