using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class RoomManager
    {
        private readonly Dictionary<string, Room> _rooms;
        public IReadOnlyDictionary<string, Room> Rooms => _rooms;

        public RoomManager()
        {
            _rooms = new Dictionary<string, Room>
            {
                { Master_Bedroom.Url, Master_Bedroom },
                { Arena.Url, Arena },
                { Chicken_Room.Url, Chicken_Room }
            };
        }

        public Room this[string url] => Rooms[url];
        public Room GetByName(string name) => _rooms.Values.FirstOrDefault(x => x.Name == name);

        public static Room Master_Bedroom { get; } = new Room(
            name: "Master Bedroom",
            url: "Master_Bedroom",
            description: "Your main bedroom. You can build various pieces of furniture to make it more comfortabal. Your house can only have one master bedroom.",
            constructionLevelRequired: 1,
            minimumPlankLevel: 0,
            planksRequired: 1000,
            minimumBarLevel: 0,
            barsRequired: 500);

        public static Room Arena { get; } = new Room(
            name: "Arena",
            url: "Arena",
            description: "The arena is a place in your home that lets you kill things. Simply build a kyonshi of the monster you want to kill, and activate it for private farming.",
            constructionLevelRequired: 20,
            minimumPlankLevel: 1,
            planksRequired: 3000,
            minimumBarLevel: 2,
            barsRequired: 1500);

        public static Room Chicken_Room { get; } = new Room(
            name: "Chicken Room",
            url: "Chicken_Room",
            description: "The chicken room can be filled with chicken coops, which produce eggs and feathers daily.",
            constructionLevelRequired: 10,
            minimumPlankLevel: 2,
            planksRequired: 4000,
            minimumBarLevel: 0,
            barsRequired: 250);
    }
}
