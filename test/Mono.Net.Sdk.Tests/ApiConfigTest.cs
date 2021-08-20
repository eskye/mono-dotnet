using System;
using Mono.Net.Sdk.Config;
using Moq;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests
{
    public class ApiConfigTest
    {
        [Fact]
        public void Enusre_SecretKey_Is_Not_Null()
        {
            var secretKey = "sk_xxxxx";
            var apiConfig = new ApiConfig(secretKey);
            apiConfig.SecretKey.ShouldNotBeNullOrEmpty();
            apiConfig.SecretKey.ShouldBe(secretKey);
        }
        
        [Fact]
        public void SecretKey_Throw_ArgumentExpection_When_NullOrEmpty()
        {
            var secretKey = string.Empty; 
            var exception = Should.Throw<ArgumentException>(() => new ApiConfig(secretKey));
            exception.Message.ShouldBe($"Your Mono api secret key is required (Parameter '{exception.ParamName}')");
        }
    }
}