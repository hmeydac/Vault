namespace Vaul.Domain.Mocks
{
    using System;
    using System.Collections.Generic;
    using Vaul.Domain.Mocks.Builders;
    using Vault.Domain.Entities;

    public class ObjectMother
    {
        private static CapabilityBuilder capabilityBuilder = new CapabilityBuilder();

        public static IEnumerable<Capability> GetEmptyCapabilityList()
        {
            return capabilityBuilder.EmptyList().Build();
        }

        public static IEnumerable<Capability> GetSimpleCapabilityList()
        {
            return capabilityBuilder.EmptyList()
          .AddItem(Guid.NewGuid(), "Test1", "TestCategory")
          .AddItem(Guid.NewGuid(), "Test2", "TestCategory")
          .AddItem(Guid.NewGuid(), "Test3", "TestCategory")
          .AddItem(Guid.NewGuid(), "Test4", "TestCategory")
            .Build();
        }

        public static IEnumerable<Capability> GetMultiCategoryCapabilityList()
        {
            return capabilityBuilder.EmptyList()
                .AddItem(Guid.NewGuid(), "Test1", "Category1")
                .AddItem(Guid.NewGuid(), "Test2", "Category2")
                .AddItem(Guid.NewGuid(), "Test3", "Category2")
                .AddItem(Guid.NewGuid(), "Test4", "Category3")
                .Build();
        }
    }
}
