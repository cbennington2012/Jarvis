using Jarvis.Domain.Contracts.Repositories;
using Jarvis.Domain.IoC;
using Jarvis.Domain.Repositories;
using Jarvis.Infrastructure.IoC;
using StructureMap;
using StructureMap.Graph;

namespace Jarvis.Api.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            return new Container(cfg =>
            {
                cfg.AddRegistry<DomainRegistry>();
                cfg.AddRegistry<InfrastructureRegistry>();

                cfg.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

                cfg.For<IMediaRepository>().Singleton().Use<MediaRepository>().OnCreation(o => o.Discover());
            });
        }
    }
}