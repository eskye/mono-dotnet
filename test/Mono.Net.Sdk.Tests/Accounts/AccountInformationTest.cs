using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Accounts
{
    public class AccountInformationTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient;
        public AccountInformationTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetAccountInformation()
        {
            var response = await _monoClient.Accounts.GetAccountInformation(ApiTestFixture.AccountId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Meta.ShouldNotBeNull();
        }
    }
}