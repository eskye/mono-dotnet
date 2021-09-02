# Mono-dotnet 

Mono-dotnet is a .net sdk wrapper for <a href="https://mono.co"> Mono </a>.
 For complete information about the API, head to the <a href="https://docs.mono.co/reference">docs</a>.
<br /><br />
## Compatibility 

SDK is compatible with both .NET Core and .NET Standard project.

## Getting Started

- Register on <a href="https://app.withmono.com/dashboard"> Mono </a>  website and get your Authorization key.
- Setup your mono connect with your mono public key.

<br/>

## Installation

 Check the Mono.Net.Sdk on nuget: [https://www.nuget.org/packages/Mono.Net.Sdk](https://www.nuget.org/packages/Mono.Net.Sdk)
 
 <br/>
Install via the nuget package manager console:

`PM> Install-Package Mono.Net.Sdk`

<br/>
Install via the dotnet cli:


 `> dotnet add package Mono.Net.Sdk` 

 ## Usage
The Mono Sdk needs to be configured with your account's `secretKey`, which is
available in the [Mono Dashboard](https://app.withmono.com/apps).

```C#
//Instantiate the MonoClient Sdk using your secret key
 var monoClient = new MonoClient("test_sk_xxxxxxxxxx");

//Get your account information, pass your accountId
 var response = await monoClient.Accounts.GetAccountInformation(accountId: "848848je94943308899");

```


## Features
 
- [Get Account ID from Auth Code](#account_id)
- [Account Information](#info)
- [Wallet Balance](#wallet)
- [Account Statement](#statement)
- [Poll Account Statement PDF](#statement_pdf)
- [Transactions](#transactions) 
- [Income Information](#income)
- [Identity](#identity)
- [Institutions](#institutions)
- [Unlink Account](#unlink)
- [Business LookUp](#business_lookup)
- [Business Shareholder Details](#business_shareholder_details)
- [Sync Data](#sync)
- [Re-auth Code](#reauth)
<br /><br />

# Implementation

## Methods

Once an instance of the client has been created you use the following methods:


### <a name="account_id"></a>Get Account Id from token
This resource returns the account id (that identifies the authenticated account) after successful enrolment on the Mono Connect Widget.

```C#

await monoClient.Auth.GetAccountId(new AuthAccountRequest
                {
                    Code = "code_xxxxxxxxxxxx"
                });

```

### <a name="info"></a>Get Account Information
This resource returns the account details with the financial institution.

```C#

 await monoClient.Accounts.GetInformation(string accountId);

```

### <a name="wallet"></a>Get Wallet Balance
This resource allows you to check the available balance in your Mono wallet

```C#

 await monoClient.User.GetWalletBalance();

```

### <a name="statement"></a>Get Account Statement in JSON
This resource returns the bank statement of the connected financial account in JSON.  
You can query 1-12 months bank statement in one single call.
```C#
await monoClient.Accounts.GetStatementsInJson(string accountId); 

```

### Get Account Statement in PDF
This resource returns the bank statement of the connected financial account in PDF.  
You can query 1-12 months bank statement in one single call.
```C#
await monoClient.Accounts.GetStatementsPdf(string accountId); 

```

### <a name="statement_pdf"></a>Poll Account Statement in PDF
With this resource, you set the output as PDF, and you can use this endpoint to poll the status

```C#
await monoClient.Accounts.GetPollPdfAccountStatementStatus(string accountId, string jobId); 

```

### <a name="transactions"></a>Get Account Transactions
This resource returns the known transactions on the account.
```C#
await monoClient.Accounts.GetTransactions(string accountId, string type="credit"); 

```
For more options you can filter with the following:
- Start: start period of the transactions eg. 01-10-2020
- End: end period of the transactions eg. 07-10-2020
- Narration: narration filters all transactions by narration e.g Uber transactions
- Limit: limit the number of transactions returned per API call
- Paginate: true or false (If you want to receive the data all at once or you want it paginated)

### <a name="income"></a>Get Income Information
This resource will return income information on the account.
```C#
 await monoClient.Accounts.GetIncome(string accountId);
```

### <a name="identity"></a>Get Account Identity
This resource returns a high level overview of an account identity data.
```C#
await monoClient.Accounts.GetUserIdentity(string accountId);
```


### <a name="institutions"></a>Get Financial Institutions
This resource returns the available institutions on Mono
```C#
await monoClient.Misc.GetInstitutions();

```

### <a name="unlink"></a>Unlink Account
This resource provides your customers with the option to unlink their financial account(s)
```C#
await monoClient.Misc.UnlinkAccount(string accountId)

```

### <a name="business_lookup"></a>Business Lookup
This resource returns the information of a particular business/company by searching with the business/company name
```C#
await monoClient.Misc.BusinessLookUp(string companyName);

```
### <a name="business_shareholder_details"></a>Business Shareholder Details
This resource returns the shareholder details of a particular business/company using the ID returned from the [business lookup](#business_lookup) method.
```C#
await monoClient.Misc.ShareholderDetails(string businessId);

```

### <a name="sync"></a>Synchronise Data
This resource attempts to Sync data manually.
```C#
 await monoClient.Auth.SyncDataManually(string accountId);
 
```
### <a name="reauth"></a>Get Re-auth Code.
This resource returns a Re-auth code which is a mono generated code for the account you want to re-authenticate,
```C#
await monoClient.Auth.ReAuthorizeCode(string accountId);
```

## License

The MIT License (MIT). Please see <a href="https://github.com/eskye/mono-dotnet/blob/main/LICENSE">License File</a> for more information.

## Contribution

If you would like to contribute to the Mono .NET SDK, Please feel free to raise a pull request.



