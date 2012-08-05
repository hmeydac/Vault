namespace Vaul.Domain.Mocks.Builders
{
    using System;
    using System.Collections.Generic;
    using Vault.Domain.Entities;

    public class CapabilityBuilder : IBuilder<IEnumerable<Capability>>
    {     
        private List<Capability> builderItem;

        public CapabilityBuilder EmptyList()
        {
            this.builderItem = new List<Capability>();
            return this;
        }

        public CapabilityBuilder AddItem(Guid id, string name, string category)
        {
            var capability = new Capability
            {
                Id = id,
                Name = name,
                Category = category
            };

            this.builderItem.Add(capability);
            return this;
        }

        public IEnumerable<Capability> Build()
        {
            return this.builderItem;
        }
    }
}
