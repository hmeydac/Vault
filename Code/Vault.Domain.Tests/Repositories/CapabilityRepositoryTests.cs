namespace Vault.Domain.Tests.Repositories
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Vaul.Domain.Mocks;
    using Vault.Domain.Repositories;

    [TestClass]
    public class CapabilityRepositoryTests
    {
        [TestMethod]
        public void InstantiateWithEmptyListShouldNotFail()
        {
            // Arrage
            var list = ObjectMother.GetEmptyCapabilityList();
            CapabilityRepository actual;

            // Act
            actual = new CapabilityRepository(list);

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.Capabilities);
            Assert.AreEqual(0, actual.Capabilities.Count());            
        }

        [TestMethod]
        public void InstantiateWithSimpleListShouldNotFail()
        {
            // Arrage
            var list = ObjectMother.GetSimpleCapabilityList();
            var expectedCount = list.Count();
            CapabilityRepository actual;

            // Act
            actual = new CapabilityRepository(list);

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.Capabilities);
            Assert.AreEqual(expectedCount, actual.Capabilities.Count());
        }
    }
}