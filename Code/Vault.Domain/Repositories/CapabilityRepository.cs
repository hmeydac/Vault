namespace Vault.Domain.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Vault.Domain.Entities;

    public class CapabilityRepository : Vault.Domain.Repositories.ICapabilityRepository
    {
        private IList<Capability> list;

        public CapabilityRepository(IEnumerable<Capability> list)
        {            
            this.list = list.ToList();
        }

        public IQueryable<Capability> Capabilities
        {
            get
            {
                return this.list.AsQueryable();
            }
        }
    }
}