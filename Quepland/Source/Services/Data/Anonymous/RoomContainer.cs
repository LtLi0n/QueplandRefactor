using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class RoomContainer : StaticEntityContainerBase<Room, string>
    {
        public RoomContainer() { }

        protected override IEnumerable<Room> LoadContent() =>
            new Room[] 
            { 
                Room.Master_Bedroom, 
                Room.Arena, 
                Room.Chicken_Room 
            };

        public Room GetByName(string name) => _content.Values.FirstOrDefault(x => x.Name == name);
    }
}
