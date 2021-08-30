using System.Linq;
using System.Threading.Tasks;
using Mono.Net.Sdk.Exceptions;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Misc
{
    public class MiscEndpointTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient;
        private static string businessId = string.Empty;
        public MiscEndpointTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetInstitutions()
        {
            var response = await _monoClient.Misc.GetInstitutions();
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
        }
        
        [Fact]
        public async Task CanGetBusinessLookUp()
        {
            var response = await _monoClient.Misc.BusinessLookUp("mono");
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
            response.Data.Count.ShouldBeGreaterThan(0);
            businessId = response.Data.First().Id;

        }
        
        [Fact]
        public async Task CanGetBusinessShareholderDetail()
        {
            var response = await _monoClient.Misc.ShareholderDetails(businessId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
            response.Data.Count.ShouldBeGreaterThan(0);
            response.Data.First().ShouldNotBeNull();

        }
        
        [Fact]
        public async Task CanUnlinkAccount()
        {
           var response = await Should.ThrowAsync<MonoApiException>(async () => await _monoClient.Misc.UnlinkAccount(ApiTestFixture.AccountId));
           response.Message.ShouldBe("This account can not be unlinked");
        }
        
    }
}