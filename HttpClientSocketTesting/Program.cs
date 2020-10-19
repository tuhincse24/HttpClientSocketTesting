using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientSocketTesting
{
    public class Program
    {
        private static HttpClient Client = new HttpClient();
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting connections");
            for (int i = 0; i < 10; i++)
            {
                var result = await Client.GetAsync("http://aspnetmonsters.com");
                Console.WriteLine(result.StatusCode);
            }
            Console.WriteLine("Connections done");
            Console.ReadLine();
        }
    }
}
