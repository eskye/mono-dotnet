using System.Threading.Tasks;
using Mono.Net.Sdk.Exceptions;
using Mono.Net.Sdk.Models.Auth;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Auth
{
    public class AuthEndpointTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient; 
        public AuthEndpointTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetAccountId()
        {
            var response = await _monoClient.Auth.GetAccountId(new AuthAccountRequest
            {
                Code = "code_vKXqsJGvUmcPOiHclRmv"
            });
            
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.AccountId.ShouldNotBeNull();
        }
        
        [Fact]
        public async Task Throw_Mono_ApiException_If_Code_Has_Expired_Or_Invalid()
        {
            var response = await Should.ThrowAsync<MonoApiException>(async () => await _monoClient.Auth.GetAccountId(
                new AuthAccountRequest
                {
                    Code = "code_vKXqsJGvUmcPOiHclRmv"
                }));
         response.Message.ShouldBe("You are using an invalid or expired code."); 
        }
        
        [Fact]
        public async Task CanManuallySyncAccountData()
        {
            var response = await _monoClient.Auth.SyncDataManually(ApiTestFixture.AccountId);
            
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Status.ShouldNotBeNull();
            response.Data.Code.ShouldNotBeNull();
        }

        [Fact]
        public async Task ReAuthenticateUser_Successful()
        {
          var response = await _monoClient.Auth.ReAuthorizeCode(ApiTestHelper.AccountId);
          response.ShouldNotBeNull();
          response.Data.ShouldNotBeNull();
          response.Data.Token.ShouldNotBeNull();
        }
  }
}