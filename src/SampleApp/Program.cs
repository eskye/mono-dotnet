using System;
using System.Threading.Tasks;
using Mono.Net.Sdk; 

namespace SampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var monoClient = new MonoClient("test_sk_tfJYGjtzgLBVnocmnH2c");
            var response = await monoClient.Accounts.GetInformation(accountId:"611eb7d6fd392d5c39acac40");
            Console.WriteLine("{0}",response.Data);
        }
    }
}