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
        private static readonly Lazy<string> LazyAccountIdConfig = new Lazy<string>(LoadAccountId);
        public static ApiConfig Configuration => LazyConfiguration.Value;
        public static readonly string AccountId = LazyAccountIdConfig.Value;
        public ApiTestFixture()
        {
            MonoClient = new MonoClient(Configuration);
        }
        
        public IMonoClient MonoClient { get; private set; }
        
        private static ApiConfig LoadConfiguration()
        {
            var configuration = GetConfiguration();
            var secretKey = configuration.GetSection("SecretKey").Value ?? "test_sk_xxxxxxxxxx";
            return new ApiConfig(secretKey);
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            return configuration;
        }

        public static string LoadAccountId()
        {
            var configuration = GetConfiguration();
            return configuration.GetSection("AccountId").Value;
        }
    }
}