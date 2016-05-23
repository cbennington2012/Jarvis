using StructureMap;
using StructureMap.Graph;

namespace Jarvis.Domain.IoC
{
    public class DomainRegistry : Registry
    {
        public DomainRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}
