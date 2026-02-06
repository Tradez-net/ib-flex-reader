namespace IbFlexReader.Tests.XmlFileTest
{
    using System.IO;
    using System.Linq;
    using IbFlexReader.Contracts;
    using IbFlexReader.Contracts.Ib;
    using NUnit.Framework;

    [TestFixture]
    public class XmlFileTests
    {
        private Reader reader;
        private TestFileHelper tfh;

        [SetUp]
        public void Setup()
        {
            reader = new Reader();
            tfh = new TestFileHelper();
        }

        [TestCase("activity_backfill.xml")]
        [TestCase("activity_bonds.xml")]
        [TestCase("activity_cancelled_trades.xml")]
        [TestCase("activity_cash.xml")]
        [TestCase("activity_cfds.xml")]
        [TestCase("activity_complex_corporate_actions.xml")]
        [TestCase("activity_corporate_actions.xml")]
        [TestCase("activity_daily_portfolio.xml")]
        [TestCase("activity_extended.xml")]
        [TestCase("activity_forex.xml")]
        [TestCase("activity_fractional_shares.xml")]
        [TestCase("activity_futures.xml")]
        [TestCase("activity_minimal.xml")]
        [TestCase("activity_options.xml")]
        [TestCase("activity_simple.xml")]
        [TestCase("activity_tbills.xml")]
        [TestCase("activity_warrants.xml")]
        [TestCase("kmi.xml")]
        [TestCase("StatementOfFunds.xml")]
        [TestCase("TestForCoding.xml")]
        public void TestXmlFileParsing(string fileName)
        {
            var filePath = Path.Combine(tfh.GetTestFilePath(), fileName);
            Assert.IsTrue(File.Exists(filePath), $"File not found: {filePath}");

            var xmlContent = File.ReadAllText(filePath);
            var result = reader.FromFile(filePath);

            Assert.IsNotNull(result, $"Parsing failed for {fileName}");
            if (result.Errors.Count > 0)
            {
                var errorDetails = string.Join("; ", result.Errors.Select(e => $"{e.Object}: {e.Message}"));
                Assert.AreEqual(0, result.Errors.Count, $"Errors found while parsing {fileName}: {errorDetails}");
            }
        }
    }
}
