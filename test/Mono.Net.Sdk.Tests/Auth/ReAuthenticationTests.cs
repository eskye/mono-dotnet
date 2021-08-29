using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Mono.Net.Sdk.Tests.Auth
{
  public class ReAuthenticationTests : IClassFixture<ApiTestFixture>
  {
    private readonly IMonoClient _monoClient;
    public ReAuthenticationTests(ApiTestFixture fixture)
    {
      _monoClient = fixture.MonoClient; // Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
    }

    [Fact]
    public async Task ReAuthenticateUser_Successful()
    {
      var response = await _monoClient.Auth.ReAuthorizeUser(ApiTestHelper.AccountId);
      response.ShouldNotBeNull();
      response.Data.ShouldNotBeNull();
      response.Data.Token.ShouldNotBeNull();
    }
  }
}
