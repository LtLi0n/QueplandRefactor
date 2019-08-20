using System.Collections.Generic;

namespace Quepland
{
    public abstract class EntityManagerBase { }

    public abstract class EntityManagerBase<T, IdT> : EntityManagerBase
        where T : IEntity<T, IdT>
    {
        protected readonly Dictionary<IdT, T> _content;
        public IReadOnlyDictionary<IdT, T> Content => _content;

        public EntityManagerBase()
        {
            _content = Load();
        }

        protected abstract Dictionary<IdT, T> Load();

        public T this[IdT url] => _content[url];
    }
}
