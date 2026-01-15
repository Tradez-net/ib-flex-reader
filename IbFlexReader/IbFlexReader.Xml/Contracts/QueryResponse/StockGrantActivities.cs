namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "StockGrantActivities")]
    public class StockGrantActivities
    {
        [XmlElement(ElementName = "StockGrantActivity")]
        public List<StockGrantActivity> StockGrantActivity { get; set; }
    }
}
