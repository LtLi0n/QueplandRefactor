using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Quepland
{
    ///<summary>Stored entity retrieval support container.</summary>
    public abstract class StoredEntityContainerBase<T, IdT> : EntityContainerBase
        where T : IEntity<T, IdT>
    {
        protected readonly Dictionary<IdT, T> _content;
        public IReadOnlyDictionary<IdT, T> Content => _content;
        
        ///<summary>Path of the file where content is to be loaded from.</summary>
        public string Path { get; }

        public T this[IdT id] => _content[id];

        public StoredEntityContainerBase(string path)
        {
            _content = new Dictionary<IdT, T>();
            Path = path;
        }

        private async Task<IEnumerable<T>> LoadContentAsync(HttpClient http) =>
            await http.GetJsonAsync<IEnumerable<T>>(Path);

        ///<summary>Load in the contents of the file at the location of <see cref="Path"/></summary>
        public async Task LoadAsync(HttpClient Http)
        {
            _content.Clear();
            var contentCollection = await LoadContentAsync(Http);
            foreach(var item in contentCollection)
            {
                _content.Add(item.Id, item);
            }
        }
    }
}
