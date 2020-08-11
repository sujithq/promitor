using System.ComponentModel;
using Xunit.Abstractions;

namespace Promitor.Tests.Integration.Services.ResourceDiscovery
{
    [Category("Resource Discovery")]
    public class ResourceDiscoveryIntegrationTest: IntegrationTest
    {
        public ResourceDiscoveryIntegrationTest(ITestOutputHelper testOutput) : base(testOutput)
        {
        }
    }
}
