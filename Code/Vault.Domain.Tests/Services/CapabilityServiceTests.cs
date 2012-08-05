namespace Vault.Domain.Tests.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Vaul.Domain.Mocks;
    using Vault.Domain.Entities;
    using Vault.Domain.Repositories;
    using Vault.Domain.Services;

    [TestClass]
    public class CapabilityServiceTests
    {
        [TestMethod]
        public void InstantiateCapabilityServiceShouldNotFail()
        {
            // Arrage
            CapabilityService actual;
            var mock = new Mock<ICapabilityRepository>();
            mock.SetupGet(repo => repo.Capabilities).Returns(ObjectMother.GetEmptyCapabilityList().AsQueryable());
            ICapabilityRepository repository = mock.Object;

            // Act
            actual = new CapabilityService(repository);

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetCapabilitiesShouldReturnList()
        {
            // Arrage
            var dataList = ObjectMother.GetSimpleCapabilityList();
            var expectedCount = dataList.Count();
            var mock = new Mock<ICapabilityRepository>();
            mock.SetupGet(repo => repo.Capabilities).Returns(dataList.AsQueryable());
            ICapabilityRepository repository = mock.Object;
            var service = new CapabilityService(repository);

            // Act
            var actual = service.GetCapabilities();

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(List<Capability>));
            Assert.AreEqual(expectedCount, actual.Count());
        }
    }
}
