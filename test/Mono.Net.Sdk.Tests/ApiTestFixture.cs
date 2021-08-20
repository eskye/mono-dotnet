using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Mono.Net.Sdk.Config; 

namespace Mono.Net.Sdk.Tests
{
    public class ApiTestFixture
    {
        private static readonly Lazy<ApiConfig> LazyConfiguration = new Lazy<ApiConfig>(LoadConfiguration);
        public static ApiConfig Configuration => LazyConfiguration.Value;
        public ApiTestFixture()
        {
            MonoClient = new MonoClient(Configuration);
        }
        
        public IMonoClient MonoClient { get; private set; }
        
        private static ApiConfig LoadConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            var secretKey = configuration.GetSection("SecretKey").Value ?? "test_sk_xxxxxxxxxx";
            return new ApiConfig(secretKey);
        }
    }
}