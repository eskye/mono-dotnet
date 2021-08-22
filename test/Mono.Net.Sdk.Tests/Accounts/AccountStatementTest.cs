using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Accounts
{
    public class AccountStatementTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient;
        private static string jobId = string.Empty;
        public AccountStatementTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetAccountStatementInJsonFormat()
        { 
            var response = await _monoClient.Accounts.GetStatementsInJson(ApiTestFixture.AccountId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Meta.ShouldNotBeNull();
        }
        
        [Fact]
        public async Task CanGetAccountStatementInPdfFormat()
        {
            var response = await _monoClient.Accounts.GetStatementsPdf(ApiTestFixture.AccountId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Id.ShouldNotBeNull();
            response.Data.Status.ShouldBe("BUILDING");
            response.Data.Path.ShouldNotBeNull();
            jobId = response.Data.Id;
        }
        
        [Fact]
        public async Task CanGetPollPdfAccountStatementStatus()
        {
            var response = await _monoClient.Accounts.GetPollPdfAccountStatementStatus(ApiTestFixture.AccountId, jobId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Id.ShouldNotBeNull();
            response.Data.Status.ShouldBe("BUILDING");
            response.Data.Path.ShouldNotBeNull();
        }
    }
}