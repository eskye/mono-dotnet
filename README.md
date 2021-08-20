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
- Poll Account Statement PDF
- Transactions
- Credits
- Debits
- Income Information
- Identity
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

 await monoClient.Accounts.GetAccountInformation(string accountId);

```

### <a name="statement"></a>Get Account Statement in JSON
This resource returns the bank statement of the connected financial account in JSON.  
You can query 1-12 months bank statement in one single call.
```C#
await monoClient.Accounts.GetAccountStatementsInJson(string accountId); 

```

### Get Account Statement in PDF
This resource returns the bank statement of the connected financial account in PDF.  
You can query 1-12 months bank statement in one single call.
```C#
await monoClient.Accounts.GetAccountStatementsPdf(string accountId); 

```

### <a name="statement_pdf"></a>Poll Account Statement in PDF
With this resource, you set the output as PDF, and you can use this endpoint to poll the status

```C#
await monoClient.Accounts.GetPollPdfAccountStatementStatus(string accountId, string jobId); 

```
## License

The MIT License (MIT). Please see <a href="https://github.com/eskye/mono-dotnet/blob/main/LICENSE">License File</a> for more information.

## Contribution

Please feel free to raise a pull request.
