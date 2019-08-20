using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class PetManager : EntityManagerBase<Pet, string>
    {
        public PetManager() { }

        protected override Dictionary<string, Pet> Load() =>
            new Dictionary<string, Pet>
            {
                { Pet.Chicken.Id, Pet.Chicken},
                { Pet.Buyable.Scarab.Id, Pet.Buyable.Scarab }
            };

        public Pet GetByName(string name) => _content.Values.FirstOrDefault(x => x.Name == name);
    }
}
