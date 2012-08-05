namespace Vault.Domain.Tests.Entities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Vault.Domain.Entities;

    [TestClass]
    public class CapabilityTests
    {
        [TestMethod]
        public void InstantiateShouldNotFail()
        {
            // Arrage
            Capability actual;

            // Act
            actual = new Capability();

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CapabilityPropertiesShouldKeepValues()
        {
            // Arrage
            Capability actual = new Capability();
            var expectedId = Guid.NewGuid();
            var expectedName = "Test Name";
            var expectedCategory = "Testing";

            // Act
            actual.Id = expectedId;
            actual.Name = expectedName;
            actual.Category = expectedCategory;

            // Assert
            Assert.AreEqual(expectedId, actual.Id);
            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedCategory, actual.Category);
        }
    }
}