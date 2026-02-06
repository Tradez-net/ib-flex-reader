namespace IbFlexReader.Contracts.Ib
{
    using System;
    using System.Xml.Serialization;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class CashTransaction
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public double? FxRateToBase { get; set; }

        public AssetCategory? AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public long? Conid { get; set; }

        public string SecurityID { get; set; }

        public string SecurityIDType { get; set; }

        public string Cusip { get; set; }

        public string Isin { get; set; }

        public string ListingExchange { get; set; }

        public long? UnderlyingConid { get; set; }

        public string UnderlyingSymbol { get; set; }

        public string UnderlyingSecurityID { get; set; }

        public string UnderlyingListingExchange { get; set; }

        public string Issuer { get; set; }

        public double? Multiplier { get; set; }

        public double? Strike { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Expiry { get; set; }

        public PutCall? PutCall { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat, order: 1)]
        [Format(Constants.DateFormat)]
        public DateTime? DateTime { get; set; }

        public double? Amount { get; set; }

        public CashTransactionType? Type { get; set; }

        public long? TradeID { get; set; }

        public string Code { get; set; }

        public long? TransactionID { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        public string ClientReference { get; set; }

        [Format(Constants.DateFormat)]
        public string SettleDate { get; set; }

        public string SerialNumber  { get; set; }
        public string DeliveryType  { get; set; }
        public string CommodityType { get; set; }
        public string Fineness      { get; set; }
        public string Weight        { get; set; }
        public string LevelOfDetail { get; set; }

        public string SubCategory { get; set; }

        public string ActionID { get; set; }

        public string Figi { get; set; }
        public string IssuerCountryCode { get; set; }
        public string AvailableForTradingDate { get; set; }
        public string ExDate { get; set; }
    }
}