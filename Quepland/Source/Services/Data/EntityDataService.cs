using Microsoft.Extensions.DependencyInjection;
using System;

namespace Quepland
{
    public class EntityDataService
    {
        private readonly IServiceProvider _services;

        public EntityDataService() 
        {
            ServiceCollection sc = new ServiceCollection();
            sc.AddSingleton<RoomManager>();
            sc.AddSingleton<PetManager>();

            _services = sc.BuildServiceProvider();
        }

        public T GetEntityManager<T>() where T : EntityManagerBase => _services.GetService<T>();
    }
}
