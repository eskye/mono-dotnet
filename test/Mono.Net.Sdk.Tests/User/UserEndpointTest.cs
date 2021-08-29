using System.Linq;
using System.Threading.Tasks;
using Mono.Net.Sdk.Exceptions;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Misc
{
    public class UserEndpointTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient; 
        public UserEndpointTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetUserWalletBalance()
        {
            var response = await _monoClient.User.GetWalletBalance();
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
        }
         
    }
}