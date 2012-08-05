namespace Vault.Domain.Repositories
{
    using System;
    using System.Linq;
    using Vault.Domain.Entities;

    public interface ICapabilityRepository
    {
        IQueryable<Capability> Capabilities { get; }
    }
}
