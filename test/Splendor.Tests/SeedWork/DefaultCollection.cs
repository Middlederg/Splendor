using Xunit;

namespace Splendor.Tests
{
    [CollectionDefinition(nameof(DefaultCollection))]
    public class DefaultCollection : ICollectionFixture<DefaultFixture>
    {

    }
}
