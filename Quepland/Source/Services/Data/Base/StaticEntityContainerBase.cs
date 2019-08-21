using System.Collections.Generic;

namespace Quepland
{
    public abstract class StaticEntityContainerBase<T, IdT> : EntityContainerBase<T, IdT>
        where T : IEntity<T, IdT>
    {
        protected abstract IEnumerable<T> LoadContent();
        public void Load()
        {
            _content.Clear();
            var items = LoadContent();
            foreach (var item in items)
            {
                _content.Add(item.Id, item);
            }
        }
    }
}
