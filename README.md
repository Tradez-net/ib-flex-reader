# IbFlexReader

A fork of the `ib-flex-reader` library, designed to simplify fetching and parsing Flex queries from Interactive Brokers. Just provide your API Token and Query ID, and the library handles the rest.

[![Nuget](https://img.shields.io/nuget/v/TradezNet.IbFlexReader.svg?style=popout)](https://www.nuget.org/packages/TradezNet.IbFlexReader/)

## Why this fork?

This version was created to modernize the original [Biehler.IbFlexReader](https://www.nuget.org/packages/Biehler.IbFlexReader/) and publish updates to an official NuGet package under the name `TradezNet.IbFlexReader`.

### Goals & Progress
- [x] **Support .NET Framework 4.8**.
- [x] **Support .NET Standard 2.0**.
- [x] **Update to the latest XML schema** for Interactive Brokers Flex Queries.
- [x] **Enhanced Data Models**: Implemented `EquitySummaryByReportDateInBase`, `CashReportCurrency`, `FxTransaction`, and `Transfer` for more detailed portfolio analysis.
- [x] **NuGet Publication**: Available as `TradezNet.IbFlexReader`.

## Migration

If you are currently using `Biehler.IbFlexReader`, simply uninstall it and install the new package:

```bash
dotnet add package TradezNet.IbFlexReader
```

## Usage

### Fetching data via API

Call the library by passing your token and query ID:

```csharp
var reader = new Reader();
FlexResult result = await reader.GetByApi(token, queryId);
```

### Parsing a local XML file

You can also parse a file that has already been downloaded:

```csharp
var reader = new Reader();
FlexQueryResponse result = reader.GetByString(filePath, new Options { UseXmlReader = true });
```

### Parsing XML content from a string

Or directly from a string containing the XML content:

```csharp
var reader = new Reader();
FlexQueryResponse result = reader.GetByString(xmlContent);
```

## Installation

Install via NuGet:

```bash
dotnet add package TradezNet.IbFlexReader
```

## Requirements
- .NET Framework 4.8 or .NET Standard 2.0.

## Contributing

Future enhancements and TODOs:
- [ ] Implement enums for `SubCategory`, `IssuerCountryCode`, `DeliveryType`, and `CommodityType` to replace raw strings.
- [ ] Expand documentation and test coverage.

Contributions are welcome!

## Thanks to 
- https://github.com/clifton/ib-flex for many FlexQuery testfiles



