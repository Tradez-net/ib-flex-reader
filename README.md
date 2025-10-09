# Fork of ib-flex-reader

This library can help you with fetching flex queries from Interactive Brokers.
Just pass Token and Query ID and wait until it has finished.

Fork of [![Nuget](https://img.shields.io/nuget/v/Biehler.IbFlexReader.svg?style=popout)](https://www.nuget.org/packages/Biehler.IbFlexReader/)

## My goals
- [x] Support .NET Framework 4.8 (~~because ExcelDNA doesn't support .NET6~~)
- [x] Update to new xml version 
- [x] Implement ```EquitySummaryByReportDateInBase,  CashReportCurrency, FxTransaction, Transfer``` for getting more informations about the depot
- [ ] publish new version(s) as nuget package

## TODOs
If you want to help, here are some enhancements:
- [ ] Creating enums for SubCategory, IssuerCountryCode, DeliveryType, CommodityType and finding all values


## Usage

Simple call the library by passing your token and queryId:

```c#
	...
	FlexResult result = new Reader().GetByApi(token, queryId).Result;
	...
```

Or pass an already downloaded file by filename:

```c#
	...
	FlexQueryResponse result = new Reader().GetByString(filename, new Options { UseXmlReader = true });
	...
```

Or pass an already downloaded file as string:

```c#
	...
	FlexQueryResponse result = new Reader().GetByString(filecontents);
	...
```

## Install
For origninal Version `nuget install Biehler.IbFlexReader`

## Requirements
It requires your application to be .NET Framework 4.8 or .NET Standard 2.0 compliant.

## IB Setup
Please read the wiki to be informed about the required IB setup.


