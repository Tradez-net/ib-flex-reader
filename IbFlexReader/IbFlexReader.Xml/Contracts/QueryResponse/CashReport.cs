namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "CashReport")]
    public class CashReport
    {
        [XmlElement(ElementName = "CashReportCurrency")]
        public List<CashReportCurrency> CashReportCurrency { get; set; }
    }
}