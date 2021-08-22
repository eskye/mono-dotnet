using System;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mono.Net.Sdk.Tests.Accounts
{
    public class TransactionEndpointTest : IClassFixture<ApiTestFixture>
    {
        private readonly IMonoClient _monoClient; 
        public TransactionEndpointTest(ApiTestFixture fixture)
        {
            _monoClient = fixture.MonoClient; //Or new MonoClient(ApiTestFixture.Configuration.SecretKey);
        }

        [Fact]
        public async Task CanGetAccountTransactionList()
        {
            var response = await _monoClient.Accounts.GetAccountTransactions(ApiTestFixture.AccountId);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            response.Data.Transactions.Count.ShouldBeGreaterThan(0);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task CanGetAccountTransactionListWithLimit(int limit)
        {
            var response = await _monoClient.Accounts.GetAccountTransactions(ApiTestFixture.AccountId,paginate:true,limit:limit);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
            response.Data.Paging.ShouldNotBeNull();
            response.Data.Transactions.Count.ShouldBe(limit);
        }
        
        [Theory]
        [InlineData("01-08-2021", "10-08-2021")] 
        public async Task CanGetAccountTransactionListWithStartAndEndDateAndNoPagination(string start, string end)
        {
            var response = await _monoClient.Accounts.GetAccountTransactions(ApiTestFixture.AccountId,start:start, end: end);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
            response.Data.Transactions.Count.ShouldBeOfType<int>();
            response.Data.Transactions.Count.ShouldBeGreaterThan(0);
        }
        
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task CanGetAccountTransactionListWithPagination(bool paginate)
        {
            var response = await _monoClient.Accounts.GetAccountTransactions(ApiTestFixture.AccountId,paginate:paginate);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull();
            if(!paginate)
                response.Data.Paging.ShouldBeNull();
            else
                response.Data.Paging.ShouldNotBeNull();
            response.Data.Transactions.Count.ShouldBeOfType<int>();
            response.Data.Transactions.Count.ShouldBeGreaterThan(0);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData("credit")]
        [InlineData("debit")] 
        public async Task CanGetAccountTransactionListWithFilter(string type)
        {
            var response = await _monoClient.Accounts.GetAccountTransactions(ApiTestFixture.AccountId,type:type);
            response.ShouldNotBeNull();
            response.Data.ShouldNotBeNull(); 
            response.Data.Transactions.Count.ShouldBeOfType<int>();
            response.Data.Transactions.Count.ShouldBeGreaterThan(0);
        }
    }
}