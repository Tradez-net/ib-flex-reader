namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "StatementOfFundsLine")]
    public class StatementOfFundsLine
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }
        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }
        [XmlAttribute(AttributeName = "activityCode")]
        public string ActivityCode { get; set; }
        [XmlAttribute(AttributeName = "activityDescription")]
        public string ActivityDescription { get; set; }
        [XmlAttribute(AttributeName = "amount")]
        public string Amount { get; set; }
        [XmlAttribute(AttributeName = "assetCategory")]
        public string AssetCategory { get; set; }
        [XmlAttribute(AttributeName = "balance")]
        public string Balance { get; set; }
        [XmlAttribute(AttributeName = "buySell")]
        public string BuySell { get; set; }
        [XmlAttribute(AttributeName = "conid")]
        public string Conid { get; set; }
        [XmlAttribute(AttributeName = "credit")]
        public string Credit { get; set; }
        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }
        [XmlAttribute(AttributeName = "cusip")]
        public string Cusip { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "debit")]
        public string Debit { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "expiry")]
        public string Expiry { get; set; }
        [XmlAttribute(AttributeName = "fxRateToBase")]
        public string FxRateToBase { get; set; }
        [XmlAttribute(AttributeName = "isin")]
        public string Isin { get; set; }
        [XmlAttribute(AttributeName = "issuer")]
        public string Issuer { get; set; }
        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }
        [XmlAttribute(AttributeName = "listingExchange")]
        public string ListingExchange { get; set; }
        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }
        [XmlAttribute(AttributeName = "multiplier")]
        public string Multiplier { get; set; }
        [XmlAttribute(AttributeName = "orderID")]
        public string OrderID { get; set; }
        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }
        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }
        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }
        [XmlAttribute(AttributeName = "securityID")]
        public string SecurityID { get; set; }
        [XmlAttribute(AttributeName = "securityIDType")]
        public string SecurityIDType { get; set; }
        [XmlAttribute(AttributeName = "settleDate")]
        public string SettleDate { get; set; }
        [XmlAttribute(AttributeName = "strike")]
        public string Strike { get; set; }
        [XmlAttribute(AttributeName = "symbol")]
        public string Symbol { get; set; }
        [XmlAttribute(AttributeName = "tradeCode")]
        public string TradeCode { get; set; }
        [XmlAttribute(AttributeName = "tradeCommission")]
        public string TradeCommission { get; set; }
        [XmlAttribute(AttributeName = "tradeGross")]
        public string TradeGross { get; set; }
        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }
        [XmlAttribute(AttributeName = "tradePrice")]
        public string TradePrice { get; set; }
        [XmlAttribute(AttributeName = "tradeQuantity")]
        public string TradeQuantity { get; set; }
        [XmlAttribute(AttributeName = "tradeTax")]
        public string TradeTax { get; set; }
        [XmlAttribute(AttributeName = "underlyingConid")]
        public string UnderlyingConid { get; set; }
        [XmlAttribute(AttributeName = "underlyingListingExchange")]
        public string UnderlyingListingExchange { get; set; }
        [XmlAttribute(AttributeName = "underlyingSecurityID")]
        public string UnderlyingSecurityID { get; set; }
        [XmlAttribute(AttributeName = "underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        // new attributes 2025

        [XmlAttribute(AttributeName = "subCategory")]
        public string SubCategory { get; set; }

        [XmlAttribute(AttributeName = "transactionID")]
        public string TransactionID { get; set; }

        [XmlAttribute(AttributeName = "figi")]
        public string Figi { get; set; }

        [XmlAttribute(AttributeName = "issuerCountryCode")]
        public string IssuerCountryCode { get; set; }

        [XmlAttribute(AttributeName = "actionID")]
        public string ActionID { get; set; }

        [XmlAttribute(AttributeName = "serialNumber")]
        public string SerialNumber { get; set; }

        [XmlAttribute(AttributeName = "deliveryType")]
        public string DeliveryType { get; set; }

        [XmlAttribute(AttributeName = "commodityType")]
        public string CommodityType { get; set; }

        [XmlAttribute(AttributeName = "fineness")]
        public string Fineness { get; set; }

        [XmlAttribute(AttributeName = "weight")]
        public string Weight { get; set; }

        [XmlAttribute(AttributeName = "relatedTransactionID")]
        public string RelatedTransactionID { get; set; }

        [XmlAttribute(AttributeName = "relatedTradeID")]
        public string RelatedTradeID { get; set; }

        [XmlAttribute(AttributeName = "origTransactionID")]
        public string OrigTransactionID { get; set; }
    }
}
