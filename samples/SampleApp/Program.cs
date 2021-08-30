using System;
using System.Threading.Tasks;
using Mono.Net.Sdk; 

namespace SampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var monoClient = new MonoClient("test_xxxxx");
            var response = await monoClient.Accounts.GetInformation(accountId:"61xxxxxxxx");
            Console.WriteLine("{0}",response.Data);
        }
    }
}