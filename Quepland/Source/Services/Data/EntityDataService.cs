using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Quepland
{
    public class EntityDataService
    {
        private readonly IServiceProvider _services;

        public EntityDataService() 
        {
            ServiceCollection sc = new ServiceCollection();

            //Static entities
            {
                sc.AddSingleton<RoomContainer>();
                sc.AddSingleton<PetContainer>();
            }

            //Stored entities
            {
                sc.AddSingleton<FollowerContainer>();
            }

            _services = sc.BuildServiceProvider();
        }

        public T GetContainer<T>() where T : EntityContainerBase => _services.GetService<T>();

        public void InitializeStaticEntites()
        {
            GetContainer<RoomContainer>().Load();
            GetContainer<PetContainer>().Load();
        }

        public async Task InitializeStoredEntities(HttpClient http)
        {
            IEnumerable<Task> readers = new Task[]
            {
                GetContainer<FollowerContainer>().LoadAsync(http)
            };

            foreach(Task reader in readers)
            {
                await reader;
            }
        }
    }
}
