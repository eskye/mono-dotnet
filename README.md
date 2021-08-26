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
 

<br />

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
 
- [Account Information](#info)
- [Account Statement](#statement)
- [Poll Account Statement PDF](#statement_pdf)
- [Transactions](#transactions) 
- [Income Information](#income)
- [Identity](#identity)
- Sync Data
- Re-auth Code
- Institutions
- BVN Lookup
- Account Unlink
<br /><br />

# Implementation

## Methods

Once an instance of the client has been created you use the following methods:


### <a name="info"></a>Get Account Information
This resource returns the account details with the financial institution.

```C#

 await monoClient.Accounts.GetInformation(string accountId);

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
await _monoClient.Accounts.GetTransactions(string accountId, string type="credit"); 

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
 await _monoClient.Accounts.GetIncome(string accountId);
```

### <a name="identity"></a>Get Account Identity
This resource returns a high level overview of an account identity data.
```C#
await _monoClient.Accounts.GetUserIdentity(string accountId);
```

## License

The MIT License (MIT). Please see <a href="https://github.com/eskye/mono-dotnet/blob/main/LICENSE">License File</a> for more information.

## Contribution

Please feel free to raise a pull request.
