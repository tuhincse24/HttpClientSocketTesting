using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientSocketTesting
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting connections");
            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient())
                {
                    var result = await client.GetAsync("http://aspnetmonsters.com");
                    Console.WriteLine(result.StatusCode);
                }
            }
            Console.WriteLine("Connections done");
        }
    }
}
