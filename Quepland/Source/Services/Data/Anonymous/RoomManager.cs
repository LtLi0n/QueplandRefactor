using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class RoomManager : EntityManagerBase<Room, string>
    {
        public RoomManager() { }

        protected override Dictionary<string, Room> Load() => 
            new Dictionary<string, Room>
            {
                { Room.Master_Bedroom.Id, Room.Master_Bedroom },
                { Room.Arena.Id, Room.Arena },
                { Room.Chicken_Room.Id, Room.Chicken_Room }
            };

        public Room GetByName(string name) => _content.Values.FirstOrDefault(x => x.Name == name);
    }
}
