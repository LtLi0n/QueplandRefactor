using System.Collections.Generic;

namespace Quepland
{
    public abstract class EntityContainerBase { }

    public abstract class EntityContainerBase<T, IdT> : EntityContainerBase
        where T : IEntity<T, IdT>
    {
        protected readonly Dictionary<IdT, T> _content;
        public IReadOnlyDictionary<IdT, T> Content => _content;

        public T this[IdT id] => _content[id];

        public EntityContainerBase()
        {
            _content = new Dictionary<IdT, T>();
        }
    }
}
