using System.Collections.Generic;

namespace Quepland
{
    public class Room : IEntity<Room, string>
    {
        public static class Ref
        {
            public const string Master_Bedroom = "Master_Bedroom";
            public const string Arena = "Arena";
            public const string Chicken_Room = "Chicken_Room";
        }

        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int ConstructionLevelRequired { get; }
        public int MinimumPlankLevel { get; }
        public int PlanksRequired { get; }
        public int MinimumBarLevel { get; }
        public int BarsRequired { get; }

        public int[][] OtherItemCosts { get; set; }
        public int ExperienceGained { get; set; }
        public bool IsComplete { get; set; }
        public int WorkRemaining { get; set; }
        public List<Furniture> Furniture { get; } = new List<Furniture>();

        public Room(
            string id, 
            string name, 
            string description, 
            int constructionLevelRequired, 
            int minimumPlankLevel, 
            int planksRequired, 
            int minimumBarLevel, 
            int barsRequired)
        {
            Id = id;
            Name = name;
            Description = description;
            ConstructionLevelRequired = constructionLevelRequired;
            MinimumPlankLevel = minimumPlankLevel;
            PlanksRequired = planksRequired;
            MinimumBarLevel = minimumBarLevel;
            BarsRequired = barsRequired;
        }

        public static Room Master_Bedroom { get; } = new Room(
            id: Ref.Master_Bedroom,
            name: "Master Bedroom",
            description: "Your main bedroom. You can build various pieces of furniture to make it more comfortabal. Your house can only have one master bedroom.",
            constructionLevelRequired: 1,
            minimumPlankLevel: 0,
            planksRequired: 1000,
            minimumBarLevel: 0,
            barsRequired: 500);

        public static Room Arena { get; } = new Room(
            id: Ref.Arena,
            name: "Arena",
            description: "The arena is a place in your home that lets you kill things. Simply build a kyonshi of the monster you want to kill, and activate it for private farming.",
            constructionLevelRequired: 20,
            minimumPlankLevel: 1,
            planksRequired: 3000,
            minimumBarLevel: 2,
            barsRequired: 1500);

        public static Room Chicken_Room { get; } = new Room(
            id: Ref.Chicken_Room,
            name: "Chicken Room",
            description: "The chicken room can be filled with chicken coops, which produce eggs and feathers daily.",
            constructionLevelRequired: 10,
            minimumPlankLevel: 2,
            planksRequired: 4000,
            minimumBarLevel: 0,
            barsRequired: 250);

    }
}
