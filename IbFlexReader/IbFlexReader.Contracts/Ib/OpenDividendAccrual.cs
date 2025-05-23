﻿namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class OpenDividendAccrual
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

        public string ExDate { get; set; }

        public string PayDate { get; set; }

        public double? Quantity { get; set; }

        public double? Tax { get; set; }

        public double? Fee { get; set; }

        public double? GrossRate { get; set; }

        public double? GrossAmount { get; set; }

        public double? NetAmount { get; set; }

        public string Code { get; set; }

        public string FromAcct { get; set; }

        public string ToAcct { get; set; }

        public string SerialNumber  { get; set; }
        public string DeliveryType  { get; set; }
        public string CommodityType { get; set; }
        public string Fineness      { get; set; }
        public string Weight        { get; set; }
    }
}