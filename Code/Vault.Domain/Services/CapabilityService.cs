namespace Vault.Domain.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Vault.Domain.Entities;
    using Vault.Domain.Repositories;

    public class CapabilityService : ICapabilityService
    {
        private ICapabilityRepository capabilityRepository;

        public CapabilityService(ICapabilityRepository capabilityRepository)
        {
            this.capabilityRepository = capabilityRepository;
        }

        public IEnumerable<Capability> GetCapabilities()
        {
            return this.capabilityRepository.Capabilities.ToList();
        }
    }
}
