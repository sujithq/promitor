using System.ComponentModel;
using Xunit.Abstractions;

namespace Promitor.Tests.Integration.Services.Scraper
{
    [Category("Scraper")]
    public class ScraperIntegrationTest: IntegrationTest
    {
        public ScraperIntegrationTest(ITestOutputHelper testOutput) : base(testOutput)
        {
        }
    }
}
