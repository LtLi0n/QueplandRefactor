using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class PetContainer : StaticEntityContainerBase<Pet, string>
    {
        public PetContainer() { }

        protected override IEnumerable<Pet> LoadContent() =>
            new Pet[]
            {
                Pet.Chicken,
                Pet.Buyable.Scarab
            };

        public Pet GetByName(string name) => _content.Values.FirstOrDefault(x => x.Name == name);
    }
}
