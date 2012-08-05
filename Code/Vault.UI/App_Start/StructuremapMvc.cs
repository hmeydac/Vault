using System.Web.Mvc;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Vault.UI.App_Start.StructuremapMvc), "Start")]

namespace Vault.UI.App_Start
{
    public static class StructuremapMvc
    {
        public static void Start()
        {
            var container = (IContainer)IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}