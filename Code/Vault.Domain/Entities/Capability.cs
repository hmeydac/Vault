namespace Vault.Domain.Entities
{
    using System;

    public class Capability
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }
    }
}