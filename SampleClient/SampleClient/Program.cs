using System;
using System.Net;
using System.Threading.Tasks;
using SampleService.Models;
using Default;

namespace SampleClient
{
    class Program
    {
        static Uri uri = new Uri("https://localhost:5001/odata");
        static async Task Main(string[] args)
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            var context = new Container(uri);
            var people = await context.People.ExecuteAsync();
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
